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
using System.Security.Cryptography.X509Certificates;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Unit.Skills;

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
            string userInput = "";
            userInput = Console.ReadLine();
            WriteMethods.WriteSeparator();

            string firstParametr = GameControll.GetFirstParametr(userInput.ToLowerInvariant());
            string lastParametr = GameControll.GetLastParametr(userInput.ToLowerInvariant());

            switch (firstParametr)
            {
                case "create":
                    if (lastParametr == "hero")
                    {
                        PlayerControll.CreateNewHero();
                        PlayerControll.DisplayHeroesList();
                    }
                    else
                    {
                        ComandNotFoundMessage();
                    }
                    break;
                case "delete":
                    if (PlayerControll.DeleteHero(lastParametr))
                    {
                        Console.WriteLine("Hero with name " + lastParametr + " succesfully deleted");
                    }
                    break;
                case "help":
                    if (lastParametr == "help")
                    {
                        Console.WriteLine("Comands possible here:\n" +
                                    "create...\n" +
                                    "show...\n" +
                                    "play + hero name (e.g \"play Stefan\")\n" +
                                    "delete + hero name(e.g \"delete Stefan\")\n" +
                                    "Try typing \"help create\" to get more information");
                    }
                    else if (lastParametr == "create")
                    {
                        Console.WriteLine("Comands possible here with create:\n" +
                                        "create hero");
                    }
                    else if (lastParametr == "show")
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
                    if(lastParametr == "characters")
                    {
                        PlayerControll.DisplayHeroesList();
                    }
                    else
                    {
                        ComandNotFoundMessage();
                    }
                    break;
                case "play":
                    if(lastParametr != "play")
                    {
                        bool exists = false;
                        try //z jakiegoś powodu po śmeirci heros w "preformFight" program wpada tutaj i daltego jest ten blok try catch
                        {
                            foreach (Hero h in PlayerControll.GetHeroesList())
                            {
                                if (h.GetName().ToLowerInvariant() == lastParametr)
                                {
                                    exists = true;
                                    Play(h);
                                }
                            }
                        }catch(System.InvalidOperationException e)
                        {
                            Console.WriteLine("Returned to Main Menu");
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
            while (PlayerControll.GetHeroesList().Contains(h))
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
                                        "findenemies/fe + place name (e.q findenemies GoblinVillage)\n" +
                                        "equip/e + item index in equipment\n" +
                                        "unequip/ue + item kind (e.q ue boody)\n" +
                                        "use/u + item index in equipment\n" + 
                                        "\"Try typing \"help show\" to get more information\"");
                        WriteMethods.WriteSeparator();
                    }
                    else if(lastParametr == "show")
                    {
                        Console.WriteLine("Comands possible here with show:\n" +
                                        "show equipment\\eq \n" +
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
                case "fe":
                    Place monsterPlace = null;
                    foreach (Place p in h.GetLocation().places)
                    {
                        if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind == PlaceKind.MONSTER_PLACE)
                        {
                            monsterPlace = p;
                            break;
                        }
                        else if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind != PlaceKind.MONSTER_PLACE)
                        {
                            Console.WriteLine("There are no monsters! (This is not \"Monster place\""); break;
                        }
                        else Console.WriteLine("Could not find place");
                    }
                    if (monsterPlace != null)
                    {
                        MonstersPlace monstersPlace = (MonstersPlace)monsterPlace;
                        switch (monstersPlace.monsters[random.Next(0, monstersPlace.monsters.Count - 1)])
                        {
                            case "Goblin":
                                Fight.PreformFight(h, MonsterGenerator.Goblin());
                                break;
                            case "Orc":
                                Fight.PreformFight(h, MonsterGenerator.Orc());
                                break;
                            default: Console.WriteLine("Something went wrong"); break;
                        }
                    }
                    break;
                case "visit":
                case "v":
                    Place place = null;
                    foreach (Place p in h.GetLocation().places)
                    {
                        if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind == PlaceKind.SHOP)
                        {
                            place = p;
                            Console.WriteLine("You are visiting " + p.name);
                            while (!VisitShop(p, h)) ;
                            break;
                        }else if (p.name.ToLowerInvariant() == lastParametr.ToLowerInvariant() && p.placeKind != PlaceKind.SHOP)
                        {
                            Console.WriteLine("You can not visit that place");
                        }
                    }
                        break;
                case "equip": 
                case "e":
                    try {
                        int itemIndex = int.Parse(lastParametr);
                        h.EquipItem(itemIndex);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("You must provide a number as second argument");
                    }
                    catch(System.InvalidCastException e)
                    {
                        Console.WriteLine("You can not equip that!");
                    }
                    WriteMethods.WriteSeparator();
                    break;
                case "unequip":
                case "ue":
                    switch (lastParametr)
                    {
                        case "head":
                            h.UnequipItem(ItemKind.HEAD_ARMOUR);
                            break;
                        case "body":
                        case "bodyarmour":
                            h.UnequipItem(ItemKind.BODY_ARMOUR);
                            break;
                        case "gloves":
                            h.UnequipItem(ItemKind.GLOVES);
                            break;
                        case "legs":
                        case "legsarmour":
                            h.UnequipItem(ItemKind.LEGS_ARMOUR);
                            break;
                        case "boots":
                            h.UnequipItem(ItemKind.BOOTS);
                            break;
                        case "weapon":
                            h.UnequipItem(ItemKind.WEAPON);
                            break;
                        case "offhand":
                            h.UnequipItem(ItemKind.OFF_HAND);
                            break;
                    }
                    break;
                case "use":
                case "u":
                    try
                    {
                        int itemIndex = int.Parse(lastParametr);
                        h.UseItem(itemIndex);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("You must provide a number as second argument");
                    }
                    catch (System.InvalidCastException e)
                    {
                        Console.WriteLine("You can not use that!");
                    }
                    WriteMethods.WriteSeparator();
                    break;
                case "cast":
                    bool used = false;
                    foreach(Skill skill in h.GetSkills())
                    {
                        if (skill.name.ToLowerInvariant() == lastParametr)
                        {
                            skill.Use(h, h);
                            used = true;
                            break;
                        }
                    }
                    if (!used)
                    {
                        Console.WriteLine("Can not find skill!");
                    }
                    break;

                default:
                    ComandNotFoundMessage();
                    break;
                    }




        }

        public static bool VisitShop(Place p, Hero h)
        {
            bool exit = false;

            Shop shop = (Shop)p;

            string userInput = Console.ReadLine();

            string firstParametr = GameControll.GetFirstParametr(userInput.ToLowerInvariant());
            string lastParametr = GameControll.GetLastParametr(userInput.ToLowerInvariant());
            try
            {
                switch (firstParametr)
                {
                    case "show":
                        if (lastParametr == "goods")
                        {
                            shop.DisplayGoods();
                        }
                        break;
                    case "buy":
                        shop.Buy(Int32.Parse(lastParametr), h);
                        break;
                    case "sell":
                        shop.Sell(Int32.Parse(lastParametr), h);
                        break;
                    case "exit":
                        exit = true;
                        break;
                    case "help":
                        Console.WriteLine("show goods\n" +
                                "buy + item index (e.g buy 2)\n" +
                                "sell + item index (e.q sell)" +
                                "exit");
                        WriteMethods.WriteSeparator();
                        break;
                    default:
                        ComandNotFoundMessage();
                        break;
                }
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Second argument (last) must be a number!");
            }
            return exit;
        }

    }
}




























