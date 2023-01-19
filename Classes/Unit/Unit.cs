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
        /*protected int healthPoints;
        protected int damage;
        protected int armour;
        protected string name;

        public Unit(int hp, int dmg)
        {
            healthPoints = hp;
            damage = dmg;
        }*/

        //stats
        protected int stamina;
        protected int strenght;
        protected int agility;
        protected int inteligence;
        protected int armour;
        protected int fireResistance;
        protected int coldResistance;
        protected int chaosResistance;

        protected float healthPoints;
        protected float damage;

        protected string name;

        public Unit(string name, int stamina, int strenght, int agility, int inteligence, 
                    int armour, int fireResistance, int coldResistance, int chaosResistance)
        {
            this.name = name;
            this.agility = agility;
            this.inteligence = inteligence;
            this.armour = armour;
            this.fireResistance = fireResistance;
            this.coldResistance = coldResistance;
            this.chaosResistance = chaosResistance;
        }

        public virtual void DisplayInformation()
        {
            Console.Write("Name: " + name + "\n" +
                "Health Points: " + healthPoints + "\n" +
                "Damage: " + damage + "\n" + 
                "Armour: " + armour + "\n");
            if (!this.IsAlive()) Console.WriteLine("Dead \n");
        }

        public void DealDamage(Unit u)
        {
            u.GetDamage(this.ReturnDamage());
        }

        public string GetName()
        {
            return name;
        }

        public void GetDamage(float d)
        {
            if(d>this.armour) this.healthPoints-=(d-this.armour);
            DisplayInformation();
        }

        public float ReturnDamage()
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












































