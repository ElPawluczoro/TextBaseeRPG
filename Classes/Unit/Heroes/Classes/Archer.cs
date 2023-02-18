using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Archer : Hero
    {

        public Archer(string n) : base(n, 8, 3, 5, 2, 2, 1, 1, 1)
        {
            this.className = "Archer";
            skills.Add(new DealingDamageSkillOneStatScalling("Toxic Arrow", Stats.AGILITY, 1.2f, DamageType.CHAOS, 10));
        }

        public override void CalculateDamage()
        {
            this.damage = agility * 0.7f;
            if (mainHand != null)
            {
                Weapon weapon = (Weapon)this.mainHand;
                damage += weapon.GetDamage() * agility * 1.2f;

            }
            if(offHand != null)
            {
                OffHand offHand = (OffHand)this.offHand;
                damage += offHand.GetDamage() * agility * 1.2f;
            }
        }

        public override void CalculateHealthPoints()
        {
            this.maxHealthPoints = stamina * 2.5f;
            this.healthPoints = maxHealthPoints;
        }
        public override void CalculateMana()
        {
            this.maxMana = 10 + intelligence * 2;
            this.mana = maxMana;
        }




    }
}
