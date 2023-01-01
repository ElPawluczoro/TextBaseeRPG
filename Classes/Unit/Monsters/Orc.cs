using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class Orc : Monster
    {
        public Orc() : base(15, 5)
        {
            this.name = "Orc";
            this.armour = 3;
            this.expierienceGiven = 10;

            this.dropListDisplay.Add("Coins(3-8)");
            this.dropListDisplay.Add("Level 1 mele weapon");
            this.dropListDisplay.Add("Orc Tooth (1-2)");

            this.dropList.Add(new Coins(random.Next(3, 8)));
            this.dropList.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
            this.dropList.Add(new LootObject("Orc Tooth", 6, random.Next(1, 2)));
        }
    }
}
