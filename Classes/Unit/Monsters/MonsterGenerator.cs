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
            return new Monster("Goblin", 10, 2, 3, dropList);
        }



    }
}
