using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;

namespace TextBasedRPG.Classes.Unit.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string n) : base(n, 10, 5, 3, 2, 3, 2, 2, 2)
        {
            this.className = "Warrior";
        }

        public override void CalculateDamage()
        {
            Weapon weapon = (Weapon)this.mainHand;
            OffHand offHand = (OffHand)this.offHand;
            this.damage = strenght * 0.6f + (weapon.GetDamage() + offHand.GetDamage()) * strenght * 1.1f;
        }

        public override void CalculateHealthPoints()
        {
            this.healthPoints = stamina * 3;
        }



    }
}
