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

        protected int damage;
        protected int healthPoints;
        protected int armour;

        public EquipableItem(string n, int v, Level rq)
        {
            this.name = n;
            this.value = v;
            this.requaierdLevel = rq;
        }

        public int GetDamage()
        {
            return this.damage;
        }

        public int GetArmour()
        {
            return this.armour;
        }

        public int GetHealthPoints()
        {
            return this.healthPoints;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Requaierd Level: " + HeroMethods.LevelToInt(this.requaierdLevel));
        }

    }
}
