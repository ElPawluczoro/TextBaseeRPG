using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems
{
    internal abstract class Weapon : EquipableItem
    {
        protected WeaponKind weaponKind;
        public Weapon(int d, string n, int v, Level rq) : base(n, v, rq)
        {
            this.kind = ItemKind.WEAPON;
            this.damage = d;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Damage: " + this.damage);
            WriteMethods.WriteSeparator();
        }







    }
}
