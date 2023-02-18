using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems
{
    internal class Weapon : EquipableItem
    {
        private float damage;

        private WeaponKind weaponKind;
        public Weapon(int stamina, int strenght, int agility, int intelligence, 
            int fireResistance, int coldResistance, int chaosResistance, int armour,
            string n, int v, Level rq, float damage, WeaponKind weaponKind) 
            : 
            base(stamina, strenght, agility, intelligence, 
                fireResistance, coldResistance, chaosResistance, armour, n, v, rq)
        {
            this.itemKind = ItemKind.WEAPON;
            this.weaponKind = weaponKind;
            this.damage = damage;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Damage: " + this.damage);
            WriteMethods.WriteSeparator();
        }

        public float GetDamage()
        {
            return this.damage;
        }







    }
}
