using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class Goblin : Monster
    {
        public Goblin() : base(10, 3)
        {
            this.name = "Goblin";
            this.armour = 1;
            this.expierienceGiven = 5;

            this.dropListDisplay.Add("Coins(1-5)");
            this.dropListDisplay.Add("Level 1 mele weapon");
            this.dropListDisplay.Add("Goblin totem (1-2)");

            this.dropList.Add(new Coins(random.Next(1,5)));
            this.dropList.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
            this.dropList.Add(new LootObject("Goblin Totem", 3, random.Next(1, 2)));
        }
    }
}
