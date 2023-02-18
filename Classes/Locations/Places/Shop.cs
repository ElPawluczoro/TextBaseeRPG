using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Locations
{
    internal class Shop : Place
    {
        protected List<NonCurrencyItem> goods = new List<NonCurrencyItem>();

        public Shop(string n, List<NonCurrencyItem> g)
        {
            this.goods = g;
            this._name = n;
            this._placeKind = Places.PlaceKind.SHOP;
        }

        public void DisplayGoods()
        {
            ItemKind[] armours = ItemsLists.armours;

            int i = 0;

            Console.WriteLine(this.name + " Goods:");
            foreach(NonCurrencyItem item in goods)
            {
                i++;
                Console.Write(i + "." + item.GetName());
                if (item.GetItemKind() == ItemKind.LOOT_OBJECT)
                {
                    LootObject lo = (LootObject)item;
                    Console.Write(" (" + lo.GetQuantity() + ")");
                }
                else if (item.GetItemKind() == ItemKind.OFF_HAND)
                {
                    OffHand of = (OffHand)item;
                    Console.Write(" d" + of.GetDamage());
                }
                else if (item.GetItemKind() == ItemKind.WEAPON)
                {
                    Weapon w = (Weapon)item;
                    Console.Write(" d" + w.GetDamage());
                }
                else if (armours.Contains(item.GetItemKind()))
                {
                    Armour armour = (Armour)item;
                    Console.Write(" a" + armour.GetArmour() + "\n stamina" + armour.stamina);
                }

                Console.WriteLine("(" + item.GetValue() + " Coins" + ")");
            }
            WriteMethods.WriteSeparator();
        }

        public void Buy(int i, Hero h)
        {
            if (i <= this.goods.Count)
            {
                NonCurrencyItem item = this.goods[i-1];
                Currency value = new Coins(item.GetValue());
                if (h.IsCurrencyEnough(value))
                {
                    h.SpendCurrency(value);
                    h.AddToEquipment(item);
                    Console.WriteLine("You bought " + item.GetName());
                }
                else Console.WriteLine("Item not found");
            }
            WriteMethods.WriteSeparator();
        }

        public void Sell(int i, Hero h)
        {
            List<NonCurrencyItem> eq = h.GetEquipment();
            NonCurrencyItem item = eq[i-1];
            if (i <= eq.Count)
            {
                if (item.GetItemKind() == ItemKind.LOOT_OBJECT)
                {
                    LootObject lo = (LootObject)item;
                    h.AddToPocket(new Coins ((int)(lo.GetQuantity() * lo.GetValue() * 0.6f)));
                }
                else if (item.GetItemKind() != ItemKind.CURRENCY)
                {
                    h.AddToPocket(new Coins((int)(item.GetValue() * 0.6f)));
                }
                h.RemoveFromEquipment(i);
            }
        }



    }
}
