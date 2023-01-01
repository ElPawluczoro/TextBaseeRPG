using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Fight;
using TextBasedRPG.Classes.Items;
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
            hero1.DisplayInformation();
            hero1.DisplayGear();
            hero1.DisplayEquipment();

            NonCurrencyItem item1 = GenerateItem.GenerateMeleWeapon(Level.LEVEL1);
            item1.DisplayInformation();

            hero1.AddToEquipment(item1);

            hero1.DisplayEquipment();

            hero1.EquipItem(1);

            hero1.DisplayInformation();
            hero1.DisplayGear();











        }
    }
}
