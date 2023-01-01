using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands
{

    internal class OffHand : EquipableItem
    {
        protected OffHandKind offHandKind;

        public OffHand(string n, int v, Level rq, int dmg, int hp, int a) : base(n, v, rq)
        {
            this.kind = ItemKind.OFF_HAND;
            this.damage = dmg;
            this.healthPoints = hp;
            this.armour = a;
        }

        public void DisplayInformation()
        {
            base.DisplayInformation();
            if (this.damage != 0) Console.WriteLine("Damage: " + this.damage);
            if (this.healthPoints != 0) Console.WriteLine("HP: " + this.healthPoints);
            if (this.armour != 0) Console.WriteLine("Armour: " + this.armour);
            WriteMethods.WriteSeparator();
        }






    }
}

















