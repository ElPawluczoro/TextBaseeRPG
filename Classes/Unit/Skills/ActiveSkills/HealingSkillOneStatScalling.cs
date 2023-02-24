using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;

namespace TextBasedRPG.Classes.Unit.Skills
{
    internal class HealingSkillOneStatScalling : Skill
    {
        Stats scalingStat;
        float scaling;
        float healing;
        public HealingSkillOneStatScalling(string name, Stats scalingStat, float scaling, float manaCost) : base(name, manaCost)
        {
            skillType = SkillType.HEALING_SKILL;

            this.scalingStat = scalingStat;
            this.scaling = scaling;
        }

        public override void ShowInformation()
        {
            throw new NotImplementedException();
        }

        public override bool Use(Unit caster, Unit target = null)
        {
            if (caster.Mana >= manaCost)
            {
                switch (scalingStat)
                {
                    case Stats.STAMINA:
                        healing = caster.Stamina * scaling;
                        break;
                    case Stats.STRENGHT:
                        healing = caster.Strenght * scaling;
                        break;
                    case Stats.AGILITY:
                        healing = caster.Agility * scaling;
                        break;
                    case Stats.INTELIGENCE:
                        healing = caster.Intelligence * scaling;
                        break;
                }
                caster.Mana -= manaCost;
                target.HealHealthPoints(healing);
                return true;
            }
            else
            {
                Console.WriteLine("Mana to low");
                WriteMethods.WriteSeparator();
                return false;
            }
        }

        public override void UseSkillMessage(Unit caster, Unit target = null)
        {
            WriteMethods.WriteGreen(caster.GetName() + " used " + name);
            if (caster == target)
            {
                WriteMethods.WriteGreen("On himself");
            }
            else WriteMethods.WriteGreen("On " + target.GetName());
        }
    }
}
