using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Heroes;

namespace TextBasedRPG.Classes.Player
{
    internal class PlayerControll
    {
        private static List<Hero> heroes = new List<Hero>(); //max 10
        private static int maxHeroes = 10;
        public static void CreateNewHero()
          
        {
            Console.WriteLine("Create new hero: \nChoose class:\n(Warrior)");
            string heroClass = Console.ReadLine();
            Console.WriteLine("Choose name for your hero");
            string name = Console.ReadLine();
            switch (heroClass){
                case "warrior": case "WARRIOR": case "Warrior":
                    if (heroes.Count < maxHeroes)
                    {
                        heroes.Add(new Warrior(name));
                        Console.WriteLine("Hero succesfully created");
                    }
                    else Console.WriteLine("You can not have more heroes");
                    break;
                default:
                    Console.WriteLine("Could not create new hero");
                    break;
            }
        }

        public static List<Hero> GetHeroesList()
        {
            return heroes;
        }

        public static void DisplayHeroesList()
        {
            int i = 0;
            foreach(Hero h in heroes)
            {
                i++;
                Console.WriteLine(i);
                h.DisplayInformation();
            }
        }





    }
}
