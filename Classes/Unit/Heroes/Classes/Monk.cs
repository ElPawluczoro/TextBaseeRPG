using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Unit.Skills;
using TextBasedRPG.Classes.Unit.Skills.Passives;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Monk : Hero
    {
        public Monk(string n) : base(n, 10, 5, 4, 2, 2, 2, 2, 2)
        {
            this.className = "Monk";
            skills.Add(new HealingSkillOneStatScalling("Peace", Stats.STAMINA, 1, 5));

            PassiveBuilder passiveBuilder = new PassiveBuilder();
            Passive holyPunch = passiveBuilder.Name("Holy punch")
                                              .PassivesRelease(PassivesReleases.ON_HIT)
                                              .AddDamageEffect(1, null, DamageType.FIRE, Target.ENEMY)
                                              .Build();
            passives.Add(holyPunch);



        }



        public override void CalculateDamage()
        {
            damage = strenght * 0.4f + agility * 0.5f;
            if(mainHand != null)
            {
                Weapon weapon = (Weapon)this.mainHand;
                this.damage += weapon.GetDamage() * agility * 1.2f;
            }
            if(offHand != null)
            {
                OffHand offHand = (OffHand)this.offHand;
                damage += offHand.GetDamage() * agility * 1.2f;
            }
        }

        public override void CalculateHealthPoints()
        {
            this.maxHealthPoints = stamina * 2.7f;
            this.healthPoints = maxHealthPoints;
        }

        public override void CalculateMana()
        {
            this.maxMana = 10 + intelligence * 3;
            this.mana = maxMana;
        }
    }
}
