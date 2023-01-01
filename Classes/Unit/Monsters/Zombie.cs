using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class Zombie : Monster
    {
        public Zombie() : base(20, 4)
        {
            this.name = "Zombie";
            this.armour = 2;
            this.expierienceGiven = 10;

            this.dropListDisplay.Add("Coins(5-10)");
            this.dropListDisplay.Add("Putrid flesh (1-2)");

            this.dropList.Add(new Coins(random.Next(5, 10)));
            this.dropList.Add(new LootObject("Putrid flesh", 3, random.Next(1, 2)));
        }
    }
}
