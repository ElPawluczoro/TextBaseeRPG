using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Fighting;
using TextBasedRPG.Classes.GameControll;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Player;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Heroes;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you are confused try typing \"help\"");
            PlayerControll.CreateNewHero("Danik");
            
            while (true)
            {
                
                GameControll.GetUserInputMenu();
            }













        }
    }
}
