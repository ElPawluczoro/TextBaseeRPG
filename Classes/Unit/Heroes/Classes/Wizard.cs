using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Wizard : Hero
    {
        public Wizard(string n) : base(n, 8, 2, 2, 5, 1, 1, 1, 1)
        {
            this.className = "Witch";
        }

        public override void CalculateDamage()
        {
            Weapon weapon = (Weapon)this.mainHand;
            OffHand offHand = (OffHand)this.offHand;
            this.damage = inteligence * 0.75f + (weapon.GetDamage() + offHand.GetDamage()) * inteligence * 1.25f;
        }

        public override void CalculateHealthPoints()
        {
            healthPoints = stamina * 2.3f;
        }


    }
}
