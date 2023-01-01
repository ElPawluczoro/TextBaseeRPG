using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Items
{
    internal class LootObject : NonCurrencyItem
    {
        protected int quantity;

        public LootObject(string n, int v, int q)
        {
            this.name = n;
            this.value = v;
            this.quantity = q;
            this.kind = ItemKind.LOOT_OBJECT;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Quantity: " + this.quantity);
        }

        public void AddLoot(LootObject lo)
        {
            if (this.name == lo.GetName())
            {
                this.quantity += lo.GetQuantity();
            }
        }
    }
}
