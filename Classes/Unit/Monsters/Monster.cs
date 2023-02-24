using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class Monster : Unit
    {
        protected int expierienceGiven; public int ExpierienceGiven { get => expierienceGiven; set => expierienceGiven = value; }

        protected List<string> dropListDisplay = new List<string>();
        protected List<Item> dropList = new List<Item>();

        protected Random random = new Random();

        public Monster()
        {

        }

        public Monster(string name, int stamina, int strenght, int agility, int intelligence,   //basic stats
                    int armour, int fireResistance, int coldResistance, int chaosResistance,    //resistances
                    int exp, List<Item> dropList,                                               //rewards
                    bool fromSt, float stMod, bool fromAg, float agMod, bool fromInt, float intMod)  //damage modifires
                    : 
                    base(name, stamina, strenght, agility, intelligence,
                    armour, fireResistance, coldResistance, chaosResistance)
        {
            this.name = name;
            this.dropList = dropList;
            this.expierienceGiven = exp;

            this.maxHealthPoints = stamina * 2;
            this.healthPoints = maxHealthPoints;
            if (fromSt)
            {
                damage += this.strenght * stMod;
            }
            if (fromAg)
            {
                damage += this.agility * agMod;
            }
            if (fromInt)
            {
                damage += this.intelligence * intMod;
            }


        }

        public void SetDropList(List<Item> dropList)
        {
            this.dropList = dropList;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            WriteMethods.WriteSeparator();
        }

        public List<Item> GetDropList()
        {
            return dropList;
        }

        public int GetExpieriencePointsGiven()
        {
            return expierienceGiven;
        }

        public void DisplayDropList()
        {
            Console.WriteLine(this.name + "Drop List: ");
            foreach (string item in dropListDisplay)
            {
                Console.WriteLine(item);
            }
            WriteMethods.WriteSeparator();
        }
    }
}
