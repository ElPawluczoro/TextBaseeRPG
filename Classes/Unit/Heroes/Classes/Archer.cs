using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Archer : Hero
    {

        public Archer(string n) : base(n, 8, 3, 5, 2, 2, 1, 1, 1)
        {
            this.className = "Archer";
        }

        public override void CalculateDamage()
        {
            Weapon weapon = (Weapon)this.mainHand;
            OffHand offHand = (OffHand)this.offHand;
            this.damage = agility * 0.7f + (weapon.GetDamage() + offHand.GetDamage() * agility * 1.2f);
        }

        public override void CalculateHealthPoints()
        {
            this.healthPoints = stamina * 2.5f;
        }


    }
}
