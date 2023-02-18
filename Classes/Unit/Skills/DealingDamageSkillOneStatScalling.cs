﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Skills
{
    internal class DealingDamageSkillOneStatScalling : Skill
    {
        Stats scalingStat;
        float scaling;
        float manaCost; public float ManaCost { get => manaCost; set => manaCost = value; }
        DamageType damageType; public DamageType DamageType { get => damageType; set => damageType = value; }

        float damage;

        public DealingDamageSkillOneStatScalling(string name, Stats scalingStat, float scaling, DamageType damageType, float manaCost)
        {
            this.name = name;
            this.scalingStat = scalingStat;
            this.scaling = scaling;
            this.damageType = damageType;
            this.manaCost = manaCost;

        }

        public override void ShowInformation()
        {
            Console.WriteLine("Skill: " + name + "\n" + "Scaling: " + HeroMethods.StatToString(scalingStat) + "*" + scaling + "\n"+ "(" + HeroMethods.DamageTypeToString(damageType) + " Damage)");
        }

        public override bool Use(Unit caster, Unit target = null)
        {
            if (caster.Mana >= manaCost)
            {
                switch (scalingStat)
                {
                    case Stats.STAMINA:
                        damage = caster.Stamina * scaling;
                        break;
                    case Stats.STRENGHT:
                        damage = caster.Strenght * scaling;
                        break;
                    case Stats.AGILITY:
                        damage = caster.Agility * scaling;
                        break;
                    case Stats.INTELIGENCE:
                        damage = caster.Intelligence * scaling;
                        break;
                }
                caster.Mana -= manaCost;
                target.GetDamage(damage, damageType);
                UseSkillMessage(caster, target);
                return true;
            }
            else
            {
                Console.WriteLine("Mana to low");
                return false;
            }
        }

        public override void UseSkillMessage(Unit caster, Unit target = null)
        {
            Console.WriteLine(caster.GetName() + " used " + name + " on " + target.GetName() + " dealing " + damage + " damage" + "(" + HeroMethods.DamageTypeToString(damageType) + " Damage)");
        }
    }
}
