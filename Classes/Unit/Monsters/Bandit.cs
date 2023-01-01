using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class Bandit : Monster
    {
        public Bandit() : base(15, 5)
        {
            this.name = "Bandit";
            this.armour = 3;
            this.expierienceGiven = 10;

            this.dropListDisplay.Add("Coins(8-15)");
            this.dropListDisplay.Add("Level 1 bow");

            this.dropList.Add(new Coins(random.Next(5, 10)));
            this.dropList.Add(GenerateItem.GenerateBow(Level.LEVEL1));
        }
    }
}
