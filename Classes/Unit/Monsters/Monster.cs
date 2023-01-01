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
        protected int expierienceGiven;

        protected List<string> dropListDisplay = new List<string>();
        protected List<Item> dropList = new List<Item>();

        protected Random random = new Random();

        public Monster(int hp, int dmg) : base(hp, dmg)
        {
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
