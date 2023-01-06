using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Player;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.GameControll
{
    internal class GameControll
    {

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
                    else if (GameControll.GetLastParametr(userInput.ToLowerInvariant()) == "create")
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
                    else ComandNotFoundMessage();
                    break;
                case "help":
                    if (lastParametr == "help")
                    {
                        Console.WriteLine("Comands possible here:\n" +
                                        "show... \n" +
                                        "\"Try typing \"help show\" to get more information\"");
                        WriteMethods.WriteSeparator();
                    }
                    else if(lastParametr == "show")
                    {
                        Console.WriteLine("Comands possible here with show:\n" +
                                        "show equipment\n" +
                                        "show pocket\n" +
                                        "show stats\n" +
                                        "show gear");
                        WriteMethods.WriteSeparator();
                    }else ComandNotFoundMessage();
                    break;
                default:
                    ComandNotFoundMessage();
                    break;
            }




        }


        }
}




























