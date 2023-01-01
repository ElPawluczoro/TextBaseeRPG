using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Items.Currency
{
    internal abstract class Currency : Item
    {
        protected int quantity;
        protected CurrencyType currencyType;

        public Currency(int q)
        {
            this.quantity = q;
            this.kind = ItemKind.CURRENCY;
        }

        public CurrencyType GetCurrencyType()
        {
            return this.currencyType;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Quantity: " + this.GetQuantity());
        }

        public void AddCurrency(Currency cr)
        {
            if(this.currencyType == cr.GetCurrencyType())
            {
                this.quantity += cr.GetQuantity();
            }
        }

        public void SubtractCurrency(Currency cr)
        {
            if (this.currencyType == cr.GetCurrencyType())
            {
                this.quantity -= cr.GetQuantity();
            }
        }


    }
}
