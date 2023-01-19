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
        protected ItemKind itemKind;

        public virtual void DisplayInformation()
        {
            Console.WriteLine(this.name);
        }

        public ItemKind GetItemKind()
        {
            return this.itemKind;
        }

        public string GetName()
        {
            return name;
        }
    }
}
