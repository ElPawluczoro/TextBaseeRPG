using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;

namespace TextBasedRPG.Classes.Unit.Monsters
{
   internal class MonsterGenerator
    {
        private static Random random = new Random();

        /*public static Monster GenerateMonster(string name, int hp, int dmg, int exp, List<Item> drop)
        {
            return new Monster(name, hp, dmg, exp, drop);
        }*/

        public static Monster Goblin()
        {
            List<Item> dropList = new List<Item>();
            dropList.Add(new Coins(random.Next(1, 3)));
            dropList.Add(new LootObject("Goblin Totem", 2, random.Next(1, 2)));
            dropList.Add(null);
            return new Monster("Goblin", 5, 4, 5, 1, 1, 0, 0, 0, 3, dropList, true, 0.5f, true, 0.6f, false, 0);
        }

        public static Monster Orc()
        {
            List<Item> dropList = new List<Item>();
            dropList.Add(new Coins(random.Next(2, 4)));
            dropList.Add(new LootObject("Orc teeth", 4, 1));
            return new Monster("Orc", 10, 5, 5, 3, 1, 0, 0, 0, 5, dropList, true, 1.5f, false, 0, false, 0);
        }

        public static Monster Zombie()
        {
            List<Item> dropList = new List<Item>();
            dropList.Add(new LootObject("Rooten flash", 3, 3));
            dropList.Add(new LootObject("Corupted blood", 6, 1));
            return new Monster("Zombie", 10, 5, 5, 3, 1, 0, 0, 0, 5, dropList, true, 1.5f, false, 0, false, 0);
        }



    }
}
