using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Fight;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Heroes;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Warrior(10, 2, "Danik");
            hero1.AddToPocket(new Coins(50));
            hero1.DisplayPocket();

            List<NonCurrencyItem> goods = new List<NonCurrencyItem>();
            goods.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
            goods.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
            goods.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
            goods.Add(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));

            Shop shop1 = new Shop("Shop", goods);

            shop1.DisplayGoods();

            shop1.Buy(1, hero1);

            hero1.DisplayPocket();
            hero1.DisplayEquipment();
            List<NonCurrencyItem> eq = hero1.GetEquipment();
            eq[0].DisplayInformation();













        }
    }
}
