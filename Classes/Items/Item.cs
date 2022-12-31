using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;

namespace TextBasedRPG.Classes.Items
{
    internal abstract class Item
    {
        protected string name;
        protected ItemKind kind;

        public void DisplayInformation()
        {
            Console.WriteLine(this.name + "\n");
        }

        public ItemKind GetItemKind()
        {
            return this.kind;
        }

        public string GetName()
        {
            return name;
        }
    }
}
