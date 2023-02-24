using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours;
using TextBasedRPG.Classes.Items.NonCurrencyItems.UsableItems;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Heroes;
using TextBasedRPG.Classes.Unit.Heroes.Classes;
using TextBasedRPG.Classes.World_;

namespace TextBasedRPG.Classes.Player
{
    internal class PlayerControll
    {
        private static List<Hero> heroes = new List<Hero>(); //max 10
        private static int maxHeroes = 10;

        public static bool IsNameAvaiable(string name)
        {
            bool isAvaiable = true;
            foreach (Hero h in heroes)
            {
                if (h.GetName() == name) isAvaiable = false;
            }
            return isAvaiable;

        }

        public static void CreateNewHero()
        {
            bool succesfullyCreated = true;

            //WorldGenerator.GenerateWorld(); //maybe will change TODO
            World world = WorldGenerator.GenerateTestWorld();

            Console.WriteLine("Create new hero: \nChoose class:\n(Warrior)\n(Archer)\n(Monk)\n(Witch)\n(Wizard)");
            string heroClass = Console.ReadLine().ToLowerInvariant();
            Console.WriteLine("Choose name for your hero");
            string name = Console.ReadLine();
            if (heroes.Count < maxHeroes && IsNameAvaiable(name))
            {
                switch (heroClass.ToLowerInvariant())
                {
                    case "warrior": heroes.Add(new Warrior(name)); break;
                    case "archer": heroes.Add(new Archer(name)); break;
                    case "monk": heroes.Add(new Monk(name)); break;
                    case "witch": heroes.Add(new Witch(name)); break;
                    case "wizard": heroes.Add(new Wizard(name)); break;
                    default: succesfullyCreated = false; break;
                }
                Hero hero = heroes[heroes.Count - 1];
                hero.SetLocation(world.worldLocations.First());
                hero.World = world;
            }
            else if (heroes.Count < maxHeroes && !IsNameAvaiable(name))
            {
                Console.WriteLine("You can not have two heroes with the same name!");
            }
            else
            {
                Console.WriteLine("You can not have more heroes");
            }

            if (!succesfullyCreated)
            {
                Console.WriteLine("This class do not exists!");
            }
        }
        public static void CreateNewHero(string n)//for tests

        {
            //WorldGenerator.GenerateWorld(); //maybe will change TODO
            World world = WorldGenerator.GenerateTestWorld();

            Console.WriteLine("Create new hero: \nChoose class:\n(Warrior)");
            string heroClass = "wizard";
            Console.WriteLine("Choose name for your hero");
            string name = n;
            switch (heroClass)
            {
                case "wizard":
                    if (heroes.Count < maxHeroes && IsNameAvaiable(n))
                    {
                        heroes.Add(new Wizard(name));
                        Console.WriteLine("Hero succesfully created");
                        heroes[0].AddToPocket(new Coins(50));
                        heroes[0].AddToEquipment(new LootObject("Totem", 5, 1));
                        heroes[0].AddToEquipment(GenerateItem.GenerateMeleWeapon(Level.LEVEL1));
                        heroes[0].AddToEquipment(new Armour(1, 1, 1, 1, 1, 1, 1, 1, "The power of basics", 33, Level.LEVEL1, ArmourKind.LIGHT_ARMOUR, ItemKind.BODY_ARMOUR));
                    }
                    else if(heroes.Count < maxHeroes && !IsNameAvaiable(n))
                    {
                        Console.WriteLine("You can not have two heroes with the same name!");
                    }
                    else Console.WriteLine("You can not have more heroes");
                    break;
                default:
                    Console.WriteLine("Could not create new hero");
                    break;
            }
            Hero hero = heroes[heroes.Count - 1];
            hero.SetLocation(world.worldLocations.First());
            hero.World = world;
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

        public static bool DeleteHero(string name)
        {
            Hero heroToDelete = null;
            bool deleted = false;
            foreach(Hero h in heroes)
            {
                if (h.GetName().ToLowerInvariant() == name)
                {
                    heroToDelete = h;
                    deleted = true;
                }
            }
            heroes.Remove(heroToDelete);
            return deleted;
        }



    }
}
