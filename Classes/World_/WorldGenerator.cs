using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.NonCurrencyItems.UsableItems;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Locations.Places;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG.Classes.World_
{
    internal class WorldGenerator
    {
       /* public static List<Place> mainTownMarketPlaces = new List<Place>();
        public static List<Location> mainTownMarketLocations = new List<Location>();
        public static Location mainTownMarket = new Location("MainTownMarket", mainTownMarketPlaces, mainTownMarketLocations);*/
        /*public static void GenerateWorld()
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
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.BODY_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.HEAD_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));

            List<NonCurrencyItem> potionsShopItems = new List<NonCurrencyItem>();
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));


            //List<Place> mainTownMarketPlaces = new List<Place>();
            mainTownMarketPlaces.Add(new Shop("Blacksmith", blackSmithItems));
            mainTownMarketPlaces.Add(new Shop("Alchemist", potionsShopItems));

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

        }*/

        public static World GenerateTestWorld()
        {
            List<NonCurrencyItem> blackSmithItems = new List<NonCurrencyItem>();
            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL1, ItemKind.BODY_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL1, ItemKind.HEAD_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL1));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL1));

            blackSmithItems.Add(GenerateItem.GenerateMeleWeapon(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.BODY_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateArmour(Unit.Level.LEVEL2, ItemKind.HEAD_ARMOUR));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));
            blackSmithItems.Add(GenerateItem.GenerateOffHand(Unit.Level.LEVEL2));

            List<NonCurrencyItem> potionsShopItems = new List<NonCurrencyItem>();
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Small healing potion", Effects.RESTORE_HP, 10, 15));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));
            potionsShopItems.Add(new UsableItem("Medium healing potion", Effects.RESTORE_HP, 25, 50));

            Location mainTownMarket = new Location("MainTownMarket");
            Location mainTownEastGate = new Location("MainTownEastGate");
            Location forest = new Location("Forest", new List<Place>(), new List<Location>());

            mainTownMarket.locationsNear.Add(mainTownEastGate);
            mainTownEastGate.locationsNear.Add(mainTownEastGate);
            mainTownEastGate.locationsNear.Add(forest);
            forest.locationsNear.Add(mainTownEastGate);

            mainTownMarket.places.Add(new Shop("Blacksmith", blackSmithItems));
            mainTownMarket.places.Add(new Shop("Alchemist", potionsShopItems));

            forest.places.Add(new MonstersPlace("GoblinsVillage", new List<string> { "Goblin" }));

            WorldBuilder worldBuilder = new WorldBuilder();
            World world = worldBuilder.AddLocation(mainTownMarket)
                                      .AddLocation(mainTownEastGate)
                                      .AddLocation(forest)
                                      .Build();

            /*World world = worldBuilder.AddLocation(mainTownMerket)
                                      .AddLocation(mainTownEastGate)
                                      .AddLocation(forest)
                                      //MAIN TOWN MARKET
                                      .AddPlaceToLocation(mainTownMerket, new Shop("Blacksmith", blackSmithItems))
                                      .AddPlaceToLocation(mainTownMerket, new Shop("Alchemist", potionsShopItems))
                                      .AddLocationToLocation(mainTownMerket, mainTownEastGate)
                                      //MAIN TOWN EAST GATE
                                      .AddLocationToLocation(mainTownEastGate, mainTownMerket)
                                      .AddLocationToLocation(mainTownEastGate, forest)
                                      //FOREST
                                      .AddLocationToLocation(forest, mainTownEastGate)
                                      .AddPlaceToLocation(forest, new MonstersPlace("GoblinsVillage", new List<string> { "Goblin" }))
                                      .Build();*/

            return world;
        }

    }
}
