using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Locations.Places;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG.Classes.World
{
    internal class WorldGenerator
    {
        public static List<Place> mainTownMarketPlaces = new List<Place>();
        public static List<Location> mainTownMarketLocations = new List<Location>();
        public static Location mainTownMarket = new Location("MainTownMarket", mainTownMarketPlaces, mainTownMarketLocations);
        public static void GenerateWorld()
        {
            //Main Town Market
            List<NonCurrencyItem> blackSmithItems = new List<NonCurrencyItem>();
            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL1, ItemKind.BODY_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL1, ItemKind.HEAD_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL1));

            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.BODY_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.HEAD_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));

            //List<Place> mainTownMarketPlaces = new List<Place>();
            mainTownMarketPlaces.Add(new Shop("Blacksmith", blackSmithItems));

            //List<Location> mainTownMarketLocations = new List<Location>();

            //Location mainTownMarket = new Location("MainTownMarket", mainTownMarketPlaces, mainTownMarketLocations);

            //Main Town East Gate
            List<Place> mainTownEastGatePlaces = new List<Place>();

            List<Location> mainTownEastGateLocations = new List<Location>();
            mainTownEastGateLocations.Add(mainTownMarket);

            Location mainTownEastGate = new Location("MainTownEastGate", mainTownEastGatePlaces, mainTownEastGateLocations);

            mainTownMarketLocations.Add(mainTownEastGate); //Main Town Market
            mainTownMarket.locationsNear = mainTownMarketLocations; //Main Town Market

            //Forest
            List<string> goblinsVillage = new List<string>();
            goblinsVillage.Add("Goblin");

            List<Place> forestPlaces = new List<Place>();


            forestPlaces.Add(new MonstersPlace("GoblinsVillage", goblinsVillage));

            List<Location> forestLoactions = new List<Location>();
            forestLoactions.Add(mainTownEastGate);

            Location forest = new Location("Forest", forestPlaces, forestLoactions);

            mainTownEastGateLocations.Add(forest); //Main Town East Gate
            mainTownEastGate.locationsNear = mainTownEastGateLocations; //Main Town East Gate






        }
    }
}
