using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Locations.Places;
using TextBasedRPG.Classes.Player;
using TextBasedRPG.Classes.Unit;
using TextBasedRPG.Classes.Unit.Monsters;
using TextBasedRPG.Classes.Fighting;

namespace TextBasedRPG.Classes.GameControll
{
    internal class GameControll
    {
        private static Random random = new Random();

        private static void ComandNotFoundMessage(){
            Console.WriteLine("Could not find comand");
            WriteMethods.WriteSeparator();
        }

       public static string GetFirstParametr(string comand)
        {
            string result = "";
            string character = "";
            for (int i = 0; i < comand.Length; i++)
            {
                character = comand[i].ToString();
                if (!character.Equals(" "))
                {
                    result += comand[i];
                }else break;
            }
            return result;
        }
        
        public static string GetLastParametr(string comand)
        {
            string result = "";
            string character = "";
            for (int i = comand.Length - 1; i > -1; i--)
            {
                character = comand[i].ToString();
                if (!character.Equals(" "))
                {
                    result += comand[i];
                }else
                {
                    break;
                }
            }
            char[] stringArray = result.ToCharArray();
            Array.Reverse(stringArray);
            result = new string(stringArray);
            return result;
        }

        public static void GetUserInputMenu()
        {
            string userInput = Console.ReadLine();
            WriteMethods.WriteSeparator();

            switch (GameControll.GetFirstParametr(userInput.ToLowerInvariant()))
            {
                case "create":
                    if (GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "hero")
                    {
                        PlayerControll.CreateNewHero();
                        PlayerControll.DisplayHeroesList();
                    }
                    else
                    {
                        ComandNotFoundMessage();
                    }
                    break;
                case "help":
                    if (GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "help")
                    {
                        Console.WriteLine("Comands possible here:\n" +
                                    "create...\n" +
                                    "show...\n" +
                                    "play + hero name (e.g \"Play Stefan\")\n" +
                                    "Try typing \"help create\" to get more information");
                    }
                    else if (GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "create")
                    {
                        Console.WriteLine("Comands possible here with create:\n" +
                                        "create hero");
                    }
                    else if (GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "show")
                    {
                        Console.WriteLine("Comands possible here with show:\n" +
                                        "show characters");
                    }
                    else
                    {
                        ComandNotFoundMessage();
                    }

                    WriteMethods.WriteSeparator();
                    break;
                case "show":
                    if(GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "characters")
                    {
                        PlayerControll.DisplayHeroesList();
                    }
                    else
                    {
                        ComandNotFoundMessage();
                    }
                    break;
                case "play":
                    if(GameControll.GetLastParametr(userInput.ToLowerInvariant()) != "play")
                    {
                        bool exists = false;
                        foreach(Hero h in PlayerControll.GetHeroesList())
                        {
                            if (h.GetName().ToLowerInvariant() == GameControll.GetLastParametr(userInput.ToLowerInvariant()))
                            {
                                exists = true;
                                Play(h);
                            }
                        }
                        if (!exists)
                        {
                            Console.WriteLine("Hero with this name not found");
                        }
                    }
                    break;
                default:
                    ComandNotFoundMessage();
                    break;
            }
        }

        public static void Play(Hero h)
        {
            Console.WriteLine("Playing with " + h.GetName());
            while (true)
            {
                GetUserInputPlay(h);
            }
        }

        public static void GetUserInputPlay(Hero h)
        {
            string userInput = Console.ReadLine();
            WriteMethods.WriteSeparator();

            string firstParametr = GameControll.GetFirstParametr(userInput.ToLowerInvariant());
            string lastParametr = GameControll.GetLastParametr(userInput.ToLowerInvariant());

            switch (firstParametr)
            {
                case "show":
                    if(lastParametr == "equipment" || lastParametr == "eq")
                    {
                        h.DisplayEquipment();
                    }
                    else if (lastParametr == "pocket")
                    {
                        h.DisplayPocket();
                    }
                    else if (lastParametr == "stats")
                    {
                        h.DisplayInformation();
                    }
                    else if (lastParametr == "gear")
                    {
                        h.DisplayGear();
                    }
                    else if (lastParametr == "location")
                    {
                        h.GetLocation().DisplayInformation();
                    }
                    else ComandNotFoundMessage();
                    break;
                case "help":
                    if (lastParametr == "help")
                    {
                        Console.WriteLine("Comands possible here:\n" +
                                        "show... \n" +
                                        "goto + location name (e.q goto MainTownMarket\n" +
                                        "findenemies + place name (e.q findenemies GoblinVillage)\n" +
                                        "\"Try typing \"help show\" to get more information\"");
                        WriteMethods.WriteSeparator();
                    }
                    else if(lastParametr == "show")
                    {
                        Console.WriteLine("Comands possible here with show:\n" +
                                        "show equipment\n" +
                                        "show pocket\n" +
                                        "show stats\n" +
                                        "show gear\n" +
                                        "show location");
                        WriteMethods.WriteSeparator();
                    }
                    else ComandNotFoundMessage();
                    break;
                case "goto":
                    bool exists = false;
                    for(int i = 0; i < h.GetLocation().locationsNear.Count; i++)
                    {
                        if (h.GetLocation().locationsNear[i].name.ToLowerInvariant() == lastParametr.ToLowerInvariant())
                        {
                            Console.WriteLine("You went to " + h.GetLocation().locationsNear[i].name);
                            h.SetLocation(h.GetLocation().locationsNear[i]);
                            WriteMethods.WriteSeparator();
                            exists = true;
                            break;
                        }
                    }
                    if (!exists) Console.WriteLine("There is not location named " + lastParametr + "/ location does not exists");
                    break;
                case "findenemies":
                    foreach (Place p in h.GetLocation().places)
                    {
                        if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind == PlaceKind.MONSTER_PLACE)
                        {
                            MonstersPlace monstersPlace = (MonstersPlace)p;
                            switch (monstersPlace.monsters[random.Next(0, monstersPlace.monsters.Count - 1)])
                            {
                                case "Goblin":
                                    Fight.PreformFight(h, MonsterGenerator.Goblin());
                                    break;
                                default: Console.WriteLine("Something went wrong"); break;
                            }
                            break;
                        }
                        else if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind != PlaceKind.MONSTER_PLACE)
                        {
                            Console.WriteLine("There are no monsters! (This is not \"Monster place\""); break;
                        }
                        else Console.WriteLine("Could not find place");
                    }
                    break;
                default:
                    ComandNotFoundMessage();
                    break;
            }




        }


        }
}




























