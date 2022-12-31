using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;

namespace TextBasedRPG.Classes.Unit
{
    internal abstract class Unit
    {
        protected int healthPoints;
        protected int damage;
        protected int armour;
        protected string name;

        public Unit(int hp, int dmg)
        {
            healthPoints = hp;
            damage = dmg;
        }

        public void DisplayInfomrmation()
        {
            Console.WriteLine("Name: " + name + "\n" +
                "Health Points: " + healthPoints + "\n" +
                "Damage: " + damage + "\n" + 
                "Armour: " + armour + "\n");
            if (!this.IsAlive()) Console.WriteLine("Dead \n");
            WriteMethods.WriteSeparator();
        }

        public void DealDamage(Unit u)
        {
            u.GetDamage(this.ReturnDamage());
        }

        public void GetDamage(int d)
        {
            if(d>this.armour) this.healthPoints-=(d-this.armour);
        }

        public int ReturnDamage()
        {
            return this.damage;
        }

        public bool IsAlive()
        {
            if(this.healthPoints<=0) return false;
            else return true;
        }

    }
}












































