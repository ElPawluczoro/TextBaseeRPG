using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Player;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG.Classes.Fighting
{
    internal class Fight
    {
        static Random random = new Random();

        public static void PreformFight(Hero h, Monster m)
        {
            while (h.IsAlive() && m.IsAlive())
            {
                h.DealDamage(m);
                m.DealDamage(h);
            }
            if (!m.IsAlive()) Fight.GiveLoot(h, m);
            if (!h.IsAlive())
            {
                PlayerControll.DeleteHero(h.GetName().ToLowerInvariant());
                Console.WriteLine("Your hero died...");
            }
        }

        public static  void GiveLoot(Hero h, Monster m)
        {
            Item lootItem;
            int randomItem;

            randomItem = random.Next(0, m.GetDropList().Count - 1);
            lootItem = m.GetDropList()[randomItem];
            if (lootItem.GetItemKind() == ItemKind.CURRENCY)
            {
                Currency lootCurrency = (Currency)lootItem;
                h.AddToPocket(lootCurrency);
            }
            else
            {
                NonCurrencyItem item = (NonCurrencyItem)lootItem;
                h.AddToEquipment(item);
            }
            h.GiveExpieriencePoints(m.GetExpieriencePointsGiven());
            Console.Write("You have got:\n" +
                    m.GetExpieriencePointsGiven() + "xp\n");
            lootItem.DisplayInformation();
            WriteMethods.WriteSeparator();



        }





    }
}
