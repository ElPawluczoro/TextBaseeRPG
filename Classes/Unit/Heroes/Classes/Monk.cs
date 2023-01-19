using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Monk : Hero
    {
        public Monk(string n) : base(n, 10, 5, 4, 2, 2, 2, 2, 2)
        {
            this.className = "Monk";
        }



        public override void CalculateDamage()
        {
            Weapon weapon = (Weapon)this.mainHand;
            OffHand offHand = (OffHand)this.offHand;
            this.damage = strenght * 0.4f + agility * 0.5f + (weapon.GetDamage() + offHand.GetDamage()) * agility * 1.2f;
        }

        public override void CalculateHealthPoints()
        {
            this.healthPoints = stamina * 2.7f;
        }
    }
}
