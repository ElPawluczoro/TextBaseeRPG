using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Weapons
{
    internal class Sword : Weapon
    {
        public Sword(int d, string n, int v, Level rq) : base(d, n, v, rq)
        {
            this.weaponKind = WeaponKind.SWORD;
        }
    }
}
