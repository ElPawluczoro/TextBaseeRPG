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
        protected int stamina; public int Stamina { get => stamina; set => stamina = value; }
        protected int strenght; public int Strenght { get => strenght; set => strenght = value; }
        protected int agility; public int Agility { get => agility; set => agility = value; }
        protected int intelligence; public int Intelligence { get => intelligence; set => intelligence = value; }
        protected int armour; public int Armour { get => armour; set => armour = value; }
        protected int fireResistance; public int FireResistance { get => fireResistance; set => fireResistance = value; }
        protected int coldResistance; public int ColdResistance { get => coldResistance; set => coldResistance = value; }
        protected int chaosResistance; public int ChaosResistance { get => chaosResistance; set => chaosResistance = value; }

        protected float maxHealthPoints; public float MaxHealthPoints { get => maxHealthPoints; set => maxHealthPoints = value; }
        protected float healthPoints; public float HealthPoints { get => healthPoints; set => healthPoints = value; }
        protected float damage; public float Damage { get => damage; set => damage = value; }
        protected float maxMana; public float MaxMana { get => maxMana; set => maxMana = value; }
        protected float mana; public float Mana { get => mana; set => mana = value; }

        protected string name;

        public Unit()
        {

        }
        public Unit(string name, int stamina, int strenght, int agility, int inteligence, 
                    int armour, int fireResistance, int coldResistance, int chaosResistance)
        {
            this.name = name;
            this.stamina = stamina;
            this.strenght = strenght;
            this.agility = agility;
            this.intelligence = inteligence;
            this.armour = armour;
            this.fireResistance = fireResistance;
            this.coldResistance = coldResistance;
            this.chaosResistance = chaosResistance;
        }

        public virtual void DisplayInformation()
        {
            Console.WriteLine("Name: " + name + "\n" +
                "Health Points: " + healthPoints + "\\" + maxHealthPoints + "\n" +
                "Mana: " + mana + "\\" + maxMana + "\n" +
                "Damage: " + damage + "\n" + 
                "Stamina: " + stamina + "\n" +
                "Strength: " + strenght + "\n" +
                "Agility: " + agility + "\n" +
                "Intelligence: " + intelligence + "\n" +
                "Armour: " + armour + "\n" +
                "Fire Resistance: " + fireResistance + "\n" +
                "Cold Resistance: " + coldResistance +"\n" +
                "Chaos Resistance: " + chaosResistance);
            if (!this.IsAlive()) Console.WriteLine("Dead \n");
        }

        public void DisplayMinimalInformation()
        {
            Console.WriteLine("Name: " + name + "\n" +
                "Health Points: " + healthPoints + "\\" + maxHealthPoints + "\n" +
                "Mana: " + mana + "\\" + maxMana);
            WriteMethods.WriteSeparator();
        }

        public void DealDamage(Unit u, DamageType dt)
        {
            u.GetDamage(this.ReturnDamage(), dt);
        }

        public string GetName()
        {
            return name;
        }

        public void GetDamage(float d, DamageType dt)
        {
            //if(d>this.armour) this.healthPoints -= (d-this.armour);
            //DisplayInformation();

            switch (dt)
            {
                case DamageType.PHYSICAL:
                    if (d > this.armour) this.healthPoints -= (d - this.armour);
                    else this.healthPoints -= 1;
                    break;
                case DamageType.FIRE:
                    if (d > this.fireResistance) this.healthPoints -= (d - this.fireResistance);
                    else this.healthPoints -= 1;
                    break;
                case DamageType.COLD:
                    if (d > this.coldResistance) this.healthPoints -= (d - this.coldResistance);
                    else this.healthPoints -= 1;
                    break;
                case DamageType.CHAOS:
                    if (d > this.chaosResistance) this.healthPoints -= (d - this.chaosResistance);
                    else this.healthPoints -= 1;
                    break;
            }

        }

        public float GetHealthPoints()
        {
            return maxHealthPoints;
        }

        public void RestoreHP(float amount)
        {
            healthPoints += amount;
            if (healthPoints > maxHealthPoints)
            {
                healthPoints = maxHealthPoints;
            }
        }

        public float ReturnDamage()
        {
            return this.damage;
        }

        public bool IsAlive()
        {
            if(this.healthPoints <= 0) return false;
            else return true;
        }

    }
}












































