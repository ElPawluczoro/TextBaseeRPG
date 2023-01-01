using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Items.Currency
{
    internal class Coins : Currency
    {
        public Coins(int q) : base(q)
        {
            this.name = "Coins";
            this.currencyType = CurrencyType.COINS;
        }
    }
}
