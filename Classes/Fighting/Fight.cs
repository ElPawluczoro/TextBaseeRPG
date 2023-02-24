using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Player;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Monsters;
using TextBasedRPG.Classes.Unit.Skills;
using TextBasedRPG.Classes.Unit.Skills.Passives;

namespace TextBasedRPG.Classes.Fighting
{
    internal class Fight
    {
        static Random random = new Random();

        /*public static void PreformFight(Hero h, Monster m)
        {
            h.DisplayInformation();
            m.DisplayInformation();
            while (h.IsAlive() && m.IsAlive())
            {
                if (h.GetSkills().Count > 0)
                {
                    h.GetSkills()[0].Use(h, m);
                }else h.DealDamage(m, DamageType.PHYSICAL);
                m.DealDamage(h, DamageType.PHYSICAL);

                h.DisplayInformation();
                m.DisplayInformation();
            }
            if (!m.IsAlive()) Fight.GiveLoot(h, m);
            if (!h.IsAlive())
            {
                PlayerControll.DeleteHero(h.GetName().ToLowerInvariant());
                Console.WriteLine("Your hero died...");
            }
        }*/

        public static void TriggerPassive(Unit.Unit user, Unit.Unit target, PassivesReleases releases)
        {
            foreach (Passive p in user.GetPassives())
            {
                if (p.PassivesRelease == releases)
                {
                    if (p.DamageTargetType == Target.SELF) p.DamageTarget = user;
                    else p.DamageTarget = target;

                    if (p.HealingTargetType == Target.SELF) p.HealingTarget = user;
                    else p.HealingTarget = target;

                    if (p.StatIncTargetType == Target.SELF) p.StatIncTarget = user;
                    else p.StatIncTarget = target;

                    p.Update();
                }
            }
        }

        public static void PreformFight(Hero h, Monster m)
        {
            h.DisplayMinimalInformation();
            m.DisplayMinimalInformation();
            TriggerPassive(m, h, PassivesReleases.COMBAT_START);
            TriggerPassive(h, m, PassivesReleases.COMBAT_START);
            while (h.IsAlive() && m.IsAlive())
            {
                Console.WriteLine("Choose action:");
                foreach(Skill skill in h.GetSkills())
                {
                    Console.WriteLine(skill.name);
                }
                Console.WriteLine("Atack");
                string action = Console.ReadLine();
                if (action.ToLowerInvariant().Equals("atack"))
                {
                    h.DealDamage(m, DamageType.PHYSICAL);
                    TriggerPassive(h, m, PassivesReleases.ON_HIT);
                    TriggerPassive(m, h, PassivesReleases.GET_HIT);
                }
                else if (HeroSkills(action, h))
                {
                    HeroUseSkill(action, h, m);
                }
                else { Console.WriteLine("You can not do that!"); WriteMethods.WriteSeparator(); continue; }


                m.DealDamage(h, DamageType.PHYSICAL);
                TriggerPassive(m, h, PassivesReleases.ON_HIT);
                TriggerPassive(h, m, PassivesReleases.GET_HIT);

                h.DisplayMinimalInformation();
                m.DisplayMinimalInformation();
            }
            if (!m.IsAlive()) 
            {
                TriggerPassive(h, m, PassivesReleases.COMBAT_END);
                Fight.GiveLoot(h, m);
            }
            if (!h.IsAlive())
            {
                PlayerControll.DeleteHero(h.GetName().ToLowerInvariant());
                Console.WriteLine("Your hero died...");
            }
        }

        public static bool HeroSkills(string skillName, Hero h)
        {
            foreach(Skill skill in h.GetSkills())
            {
                if (skill.name.ToLowerInvariant().Equals(skillName.ToLowerInvariant()))
                {
                    return true;
                }
            }
            return false;
        } 

        public static void HeroUseSkill(string skillName, Hero h, Monster m)
        {
            foreach (Skill skill in h.GetSkills())
            {
                if (skill.name.ToLowerInvariant().Equals(skillName.ToLowerInvariant()) && skill.SkillType == SkillType.DEALING_DAMAGE_SKILL)
                {
                    skill.Use(h, m);
                }
                else
                {
                    skill.Use(h, h);
                }
            }
        }

        public static void GiveLoot(Hero h, Monster m)
        {
            Item lootItem;
            int randomItem;

            randomItem = random.Next(0, m.GetDropList().Count - 1);
            lootItem = m.GetDropList()[randomItem];
            if (lootItem.GetItemKind() == ItemKind.CURRENCY)
            {
                Currency lootCurrency = (Currency)lootItem;
                h.AddToPocket(lootCurrency);
            }
            else
            {
                NonCurrencyItem item = (NonCurrencyItem)lootItem;
                h.AddToEquipment(item);
            }
            h.GiveExpieriencePoints(m.GetExpieriencePointsGiven());
            Console.Write("You have got:\n" +
                    m.GetExpieriencePointsGiven() + "xp\n");
            lootItem.DisplayInformation();
            WriteMethods.WriteSeparator();



        }





    }
}
