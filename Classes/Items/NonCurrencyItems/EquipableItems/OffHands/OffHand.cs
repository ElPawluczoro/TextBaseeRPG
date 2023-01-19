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
        protected float damage;

        protected OffHandKind offHandKind;

        /*public OffHand(string n, int v, Level rq, int dmg, int hp, int a) : base(n, v, rq)
        {
            this.kind = ItemKind.OFF_HAND;
            this.damage = damage;
            this.armour = a;
        }*/

        public OffHand(int stamina, int strenght, int agility, int intelligence,
            int fireResistance, int coldResistance, int chaosResistance, int armour,
            string n, int v, Level rq, float damage, OffHandKind offHandKind)
            :
            base(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, n, v, rq)
        {
            this.itemKind = ItemKind.WEAPON;
            this.offHandKind = offHandKind;
            this.damage = damage;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            if (this.damage != 0) Console.WriteLine("Damage: " + this.damage);
            if (this.armour != 0) Console.WriteLine("Armour: " + this.armour);
            WriteMethods.WriteSeparator();
        }

        public float GetDamage()
        {
            return this.damage;
        }






    }
}

















