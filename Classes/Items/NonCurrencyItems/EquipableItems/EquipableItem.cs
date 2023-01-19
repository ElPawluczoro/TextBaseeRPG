using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items
{
    internal abstract class EquipableItem : NonCurrencyItem
    {
        protected Level requaierdLevel;

        protected int stamina;
        protected int strenght;
        protected int agility;
        protected int intelligence;
        protected int fireResistance;
        protected int coldResistance;
        protected int chaosResistance;
        protected int armour;

        public EquipableItem(int stamina, int strenght, int agility, int intelligence,
            int fireResistance, int coldResistance, int chaosResistance, int armour,
            string name, int value, Level rq)
        {
            this.stamina = stamina;
            this.strenght = strenght;
            this.agility = agility;
            this.intelligence = intelligence;
            this.fireResistance = fireResistance;
            this.coldResistance = coldResistance;
            this.chaosResistance = chaosResistance;
            this.armour = armour;

            this.name = name;
            this.value = value;
            this.requaierdLevel = rq;
        }

        public int GetArmour()
        {
            return armour;
        }

        public int GetStamina()
        {
            return stamina;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Requaierd Level: " + HeroMethods.LevelToInt(this.requaierdLevel));
            if (this.armour != 0) Console.WriteLine("Armour: " + this.armour);
        }

    }
}
