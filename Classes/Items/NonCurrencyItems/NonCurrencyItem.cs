using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Items
{
    internal abstract class NonCurrencyItem : Item
    {
        protected int value;

        public int GetValue()
        {
            return value;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Value: " + this.value);
        }
    }
}
