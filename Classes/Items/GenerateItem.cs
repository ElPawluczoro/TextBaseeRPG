﻿using System;

using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items
{
    internal class GenerateItem
    {
        protected static Random random = new Random();

        public static Weapon GenerateMeleWeapon(Level l)
        {

            int stamina = 0;
            int strenght = 0;
            int agility = 0;
            int intelligence = 0;
            int fireResistance = 0;
            int coldResistance = 0;
            int chaosResistance = 0;
            int armour = 0;

            int damage = 0;
            int value = 0;
            string name = "";

            switch (l)
            {
                case Level.LEVEL1:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "Broken ";
                            damage = random.Next(1, 2);
                            value = random.Next(6, 10);
                            break;
                        case 2:
                            name = "Rusty ";
                            damage = random.Next(1, 3);
                            value = random.Next(9, 11);
                            break;
                        case 3:
                            name = "Simply ";
                            damage = random.Next(2, 4);
                            value = random.Next(12, 20);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Wooden ";
                            damage += random.Next(1, 2);
                            value += random.Next(9, 12);
                            break;
                        case 2:
                            name += "Cheap Copper ";
                            damage += random.Next(2, 4);
                            value += random.Next(16, 25);
                            break;
                        case 3:
                            name += "Cheap ";
                            damage += random.Next(3, 5);
                            value += random.Next(25, 40);
                            break;
                    }
                    break;
                case Level.LEVEL2:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "Rusty ";
                            damage = random.Next(2, 3);
                            value = random.Next(15, 25);
                            break;
                        case 2:
                            name = "Simply ";
                            damage = random.Next(2, 3);
                            value = random.Next(15, 25);
                            break;
                        case 3:
                            name = "Basic ";
                            damage = random.Next(3, 5);
                            value = random.Next(30, 45);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Cheap Iron ";
                            damage += random.Next(4, 6);
                            value += random.Next(30, 40);
                            break;
                        case 2:
                            name += "Iron ";
                            damage += random.Next(6, 8);
                            value += random.Next(35, 50);
                            break;
                        case 3:
                            name += "Steel ";
                            damage += random.Next(7, 10);
                            value += random.Next(45, 65);
                            break;
                    }
                    break;
                case Level.LEVEL3:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "Badly Made ";
                            damage = random.Next(3, 5);
                            value = random.Next(30, 45);
                            break;
                        case 2:
                            name = "";
                            damage = random.Next(4, 6);
                            value = random.Next(40, 60);
                            break;
                        case 3:
                            name = "Good Made ";
                            damage = random.Next(3, 5);
                            value = random.Next(60, 85);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Perfect Steel ";
                            damage += random.Next(8, 11);
                            value += random.Next(60, 80);
                            break;
                        case 2:
                            name += "Palladium ";
                            damage += random.Next(9, 12);
                            value += random.Next(70, 90);
                            break;
                        case 3:
                            name += "Perfrct Palladium ";
                            damage += random.Next(10, 13);
                            value += random.Next(85, 110);
                            break;
                    }
                    break;

                case Level.LEVEL4:
                    //code...
                    break;
                case Level.LEVEL5:
                    //code...
                    break;
                case Level.LEVEL6:
                    //code...
                    break;
                default: //LEVEL7
                    //code...
                    break;
            }

            switch (random.Next(1, 2))
            {
                case 1:
                    name += "Sword";
                    return new Weapon(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, value, l, damage, WeaponKind.SWORD);
                case 2:
                    name += "Mace";
                    return new Weapon(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, value, l, damage, WeaponKind.MACE);
                default:
                    Console.WriteLine("something unexpected happend");
                    return new Weapon(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, value, l, damage, WeaponKind.SWORD);

            }
        }
        //method ends here

        public static Weapon GenerateBow(Level l)
        {

            int stamina = 0;
            int strenght = 0;
            int agility = 0;
            int intelligence = 0;
            int fireResistance = 0;
            int coldResistance = 0;
            int chaosResistance = 0;
            int armour = 0;

            int damage = 0;
            int value = 0;
            string name = "";

            switch (l)
            {
                case Level.LEVEL1:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "Broken ";
                            damage = random.Next(0, 1);
                            value = random.Next(8, 10);
                            break;
                        case 2:
                            name = "Badly made ";
                            damage = random.Next(1, 2);
                            value = random.Next(9, 12);
                            break;
                        case 3:
                            name = "Simply ";
                            damage = random.Next(2, 3);
                            value = random.Next(13, 18);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Short Oak ";
                            damage += random.Next(2, 3);
                            value += random.Next(9, 11);
                            break;
                        case 2:
                            name += "Oak ";
                            damage += random.Next(3, 4);
                            value += random.Next(16, 25);
                            break;
                        case 3:
                            name += "Long Oak ";
                            damage += random.Next(4, 5);
                            value += random.Next(25, 40);
                            break;
                    }
                    break;
                case Level.LEVEL2:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "";
                            damage = random.Next(1, 2);
                            value = random.Next(11, 22);
                            break;
                        case 2:
                            name = "Good Made ";
                            damage = random.Next(2, 3);
                            value = random.Next(17, 25);
                            break;
                        case 3:
                            name = "Perfectly Made ";
                            damage = random.Next(3, 4);
                            value = random.Next(30, 43);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Short Red Oak ";
                            damage += random.Next(3, 4);
                            value += random.Next(31, 35);
                            break;
                        case 2:
                            name += "Red Oak ";
                            damage += random.Next(3, 4);
                            value += random.Next(35, 45);
                            break;
                        case 3:
                            name += "Long Red Oak ";
                            damage += random.Next(4, 5);
                            value += random.Next(45, 55);
                            break;
                    }
                    break;
                case Level.LEVEL3:
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name = "";
                            damage = random.Next(3, 4);
                            value = random.Next(30, 45);
                            break;
                        case 2:
                            name = "Good Made ";
                            damage = random.Next(5, 6);
                            value = random.Next(40, 60);
                            break;
                        case 3:
                            name = "Perfectly Made ";
                            damage = random.Next(5, 6);
                            value = random.Next(60, 85);
                            break;
                    }
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            name += "Short Maple Oak ";
                            damage += random.Next(5, 6);
                            value += random.Next(60, 80);
                            break;
                        case 2:
                            name += "Maple Oak ";
                            damage += random.Next(7, 8);
                            value += random.Next(70, 90);
                            break;
                        case 3:
                            name += "Long Maple Oak ";
                            damage += random.Next(8, 10);
                            value += random.Next(85, 110);
                            break;
                    }
                    break;
                case Level.LEVEL4:
                    //code...
                    break;
                case Level.LEVEL5:
                    //code...
                    break;
                case Level.LEVEL6:
                    //code...
                    break;
                default:
                    break;
            }
            name += "Bow";
            return new Weapon(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, value, l, damage, WeaponKind.BOW);
        }
        //method ends here

        public static Armour GenerateArmour(Level l, ItemKind ik)
        {
            int armour = 0;
            int stamina = 0;
            int value = 0;
            ArmourKind armourKind = ArmourKind.LIGHT_ARMOUR; //to tak mozliwe ze nie powinno być
            string name = "";

            string name1 = "";
            int stamina1h = 0;
            int armour1h = 0;
            int stamina1m = 0;
            int armour1m = 0;
            int stamina1l = 0;
            int armour1l = 0;
            int value1 = 0;
            string name2 = "";
            int stamina2h = 0;
            int armour2h = 0;
            int stamina2m = 0;
            int armour2m = 0;
            int stamina2l = 0;
            int armour2l = 0;
            int value2 = 0;
            string name3 = "";
            int stamina3h = 0;
            int armour3h = 0;
            int stamina3m = 0;
            int armour3m = 0;
            int stamina3l = 0;
            int armour3l = 0;
            int value3 = 0;
            //2
            string name1h_2 = "";
            int stamina1h_2 = 0;
            int armour1h_2 = 0;
            string name1m_2 = "";
            int stamina1m_2 = 0;
            int armour1m_2 = 0;
            string name1l_2 = "";
            int stamina1l_2 = 0;
            int armour1l_2 = 0;
            int value1_2 = 0;

            string name2h_2 = "";
            int stamina2h_2 = 0;
            int armour2h_2 = 0;
            string name2m_2 = "";
            int stamina2m_2 = 0;
            int armour2m_2 = 0;
            string name2l_2 = "";
            int stamina2l_2 = 0;
            int armour2l_2 = 0;
            int value2_2 = 0;

            string name3h_2 = "";
            int stamina3h_2 = 0;
            int armour3h_2 = 0;
            string name3m_2 = "";
            int stamina3m_2 = 0;
            int armour3m_2 = 0;
            string name3l_2 = "";
            int stamina3l_2 = 0;
            int armour3l_2 = 0;
            int value3_2 = 0;

            switch (random.Next(1, 3))
            {
                case 1:
                    armourKind = ArmourKind.LIGHT_ARMOUR;
                    break;
                case 2:
                    armourKind = ArmourKind.MEDIUM_ARMOUR;
                    break;
                case 3:
                    armourKind = ArmourKind.HEAVY_ARMOUR;
                    break;
            }
            switch (ik)
            {
                case ItemKind.HEAD_ARMOUR:
                    switch (l)
                    {
                        case Level.LEVEL1:
                            //1
                            name1 = "Badly Made ";
                            stamina1h = 1;
                            armour1h = 1;
                            stamina1m = 0;
                            armour1m = 1;
                            stamina1l = 0;
                            armour1l = 0;
                            value1 = random.Next(5, 9);
                            name2 = "";
                            stamina2h = 3;
                            armour2h = 1;
                            stamina2m = 1;
                            armour2m = 1;
                            stamina2l = 0;
                            armour2l = 1;
                            value2 = random.Next(8, 14);
                            name3 = "Good Made ";
                            stamina3h = 4;
                            armour3h = 2;
                            stamina3m = 2;
                            armour3m = 2;
                            stamina3l = 0;
                            armour3l = 2;
                            value3 = random.Next(13, 17);
                            //2
                            name1h_2 = "Cheap Copper ";
                            stamina1h_2 = random.Next(1, 2);
                            armour1h_2 = 1;
                            name1m_2 = "Poor Lether ";
                            stamina1m_2 = random.Next(0, 1);
                            armour1m_2 = 1;
                            name1l_2 = "Poor Cloth ";
                            stamina1l_2 = 1;
                            armour1l_2 = random.Next(0, 1);
                            value1_2 = random.Next(6, 10);

                            name2h_2 = "Copper ";
                            stamina2h_2 = random.Next(2, 4);
                            armour2h_2 = 2;
                            name2m_2 = "Lether ";
                            stamina2m_2 = random.Next(1, 2);
                            armour2m_2 = 1;
                            name2l_2 = "Cloth ";
                            stamina2l_2 = 1;
                            armour2l_2 = 1;
                            value2_2 = random.Next(9, 16);

                            name3h_2 = "Good Copper ";
                            stamina3h_2 = random.Next(3, 6);
                            armour3h_2 = random.Next(2, 3);
                            name3m_2 = "Strong Lether ";
                            stamina3m_2 = random.Next(2, 3);
                            armour3m_2 = 2;
                            name3l_2 = "Expensive Cloth ";
                            stamina3l_2 = random.Next(2, 4);
                            armour3l_2 = 1;
                            value3_2 = random.Next(13, 19);
                            break;
                        case Level.LEVEL2:
                            //code...
                            break;
                        case Level.LEVEL3:
                            //code...
                            break;
                        case Level.LEVEL4:
                            //code...
                            break;
                        case Level.LEVEL5:
                            //code...
                            break;
                        case Level.LEVEL6:
                            //code...
                            break;
                        default: //Level 7
                            //code...
                            break;
                    }
                    break;
                case ItemKind.BODY_ARMOUR:
                    switch (l)
                    {
                        case Level.LEVEL1:
                            //1
                            name1 = "Badly Made ";
                            stamina1h = random.Next(1, 3);
                            armour1h = 2;
                            stamina1m = random.Next(1, 2);
                            armour1m = 1;
                            stamina1l = 1;
                            armour1l = random.Next(0, 1);
                            value1 = random.Next(6, 10);
                            name2 = "";
                            stamina2h = random.Next(2, 5);
                            armour2h = random.Next(2, 3);
                            stamina2m = random.Next(2, 3);
                            armour2m = random.Next(1, 2);
                            stamina2l = random.Next(1, 2);
                            armour2l = 1;
                            value2 = random.Next(10, 20);
                            name3 = "Good Made ";
                            stamina3h = random.Next(3, 8);
                            armour3h = random.Next(3, 4);
                            stamina3m = random.Next(3, 5);
                            armour3m = random.Next(2, 3);
                            stamina3l = random.Next(1, 2);
                            armour3l = 2;
                            value3 = random.Next(15, 22);
                            //2
                            name1h_2 = "Cheap Copper ";
                            stamina1h_2 = random.Next(3, 4);
                            armour1h_2 = 1;
                            name1m_2 = "Poor Lether ";
                            stamina1m_2 = random.Next(1, 3);
                            armour1m_2 = 1;
                            name1l_2 = "Poor Cloth ";
                            stamina1l_2 = 2;
                            armour1l_2 = random.Next(0, 1);
                            value1_2 = random.Next(8, 12);

                            name2h_2 = "Copper ";
                            stamina2h_2 = random.Next(3, 6);
                            armour2h_2 = 2;
                            name2m_2 = "Lether ";
                            stamina2m_2 = random.Next(2, 5);
                            armour2m_2 = random.Next(1, 2);
                            name2l_2 = "Cloth ";
                            stamina2l_2 = random.Next(2, 3);
                            armour2l_2 = 1;
                            value2_2 = random.Next(11, 18);

                            name3h_2 = "Good Copper ";
                            stamina3h_2 = random.Next(4, 6);
                            armour3h_2 = random.Next(2, 3);
                            name3m_2 = "Strong Lether ";
                            stamina3m_2 = random.Next(3, 4);
                            armour3m_2 = 2;
                            name3l_2 = "Expensive Cloth ";
                            stamina3l_2 = random.Next(3, 5);
                            armour3l_2 = 1;
                            value3_2 = random.Next(16, 25);
                            break;
                        case Level.LEVEL2:
                            //code...
                            break;
                        case Level.LEVEL3:
                            //code...
                            break;
                        case Level.LEVEL4:
                            //code...
                            break;
                        case Level.LEVEL5:
                            //code...
                            break;
                        case Level.LEVEL6:
                            //code...
                            break;
                        default: //Level 7
                            //code...
                            break;
                    }
                    break;

                case ItemKind.GLOVES:
                    switch (l)
                    {
                        case Level.LEVEL1:
                            //1
                            name1 = "Badly Made ";
                            stamina1h = random.Next(1, 3);
                            armour1h = 0;
                            stamina1m = random.Next(1, 2);
                            armour1m = 0;
                            stamina1l = 1;
                            armour1l = 0;
                            value1 = random.Next(4, 6);
                            name2 = "";
                            stamina2h = random.Next(2, 4);
                            armour2h = 0;
                            stamina2m = random.Next(2, 3);
                            armour2m = 0;
                            stamina2l = 2;
                            armour2l = 0;
                            value2 = random.Next(6, 10);
                            name3 = "Good Made ";
                            stamina3h = random.Next(4, 6);
                            armour3h = 1;
                            stamina3m = random.Next(4, 6);
                            armour3m = 0;
                            stamina3l = random.Next(2, 4);
                            armour3l = 0;
                            value3 = random.Next(10, 15);
                            //2
                            name1h_2 = "Cheap Copper ";
                            stamina1h_2 = random.Next(1, 2);
                            armour1h_2 = 0;
                            name1m_2 = "Poor Lether ";
                            stamina1m_2 = 1;
                            armour1m_2 = 0;
                            name1l_2 = "Poor Cloth ";
                            stamina1l_2 = random.Next(0, 1);
                            armour1l_2 = 0;
                            value1_2 = random.Next(5, 8);

                            name2h_2 = "Copper ";
                            stamina2h_2 = random.Next(2, 3);
                            armour2h_2 = 0;
                            name2m_2 = "Lether ";
                            stamina2m_2 = random.Next(1, 2);
                            armour2m_2 = 0;
                            name2l_2 = "Cloth ";
                            stamina2l_2 = 1;
                            armour2l_2 = 1;
                            value2_2 = random.Next(6, 9);

                            name3h_2 = "Good Copper ";
                            stamina3h_2 = random.Next(3, 5);
                            armour3h_2 = random.Next(0, 1);
                            name3m_2 = "Strong Lether ";
                            stamina3m_2 = random.Next(2, 3);
                            armour3m_2 = random.Next(0, 1);
                            name3l_2 = "Expensive Cloth ";
                            stamina3l_2 = random.Next(2, 3);
                            armour3l_2 = 0;
                            value3_2 = random.Next(9, 13);
                            break;
                        case Level.LEVEL2:
                            //code...
                            break;
                        case Level.LEVEL3:
                            //code...
                            break;
                        case Level.LEVEL4:
                            //code...
                            break;
                        case Level.LEVEL5:
                            //code...
                            break;
                        case Level.LEVEL6:
                            //code...
                            break;
                        default: //Level 7
                            //code...
                            break;
                    }
                    break;
                case ItemKind.LEGS_ARMOUR:
                    switch (l)
                    {
                        case Level.LEVEL1:
                            //1
                            name1 = "Badly Made ";
                            stamina1h = random.Next(2, 3);
                            armour1h = random.Next(1, 2);
                            stamina1m = random.Next(1, 2);
                            armour1m = random.Next(0, 1);
                            stamina1l = random.Next(1, 2);
                            armour1l = 0;
                            value1 = random.Next(6, 10);
                            name2 = "";
                            stamina2h = random.Next(3, 4);
                            armour2h = random.Next(2, 3);
                            stamina2m = random.Next(2, 3);
                            armour2m = random.Next(1, 2);
                            stamina2l = random.Next(1, 3);
                            armour2l = random.Next(0, 1);
                            value2 = random.Next(9, 15);
                            name3 = "Good Made ";
                            stamina3h = random.Next(5, 7);
                            armour3h = random.Next(3, 4);
                            stamina3m = random.Next(4, 6);
                            armour3m = 3;
                            stamina3l = random.Next(2, 4);
                            armour3l = random.Next(1, 2);
                            value3 = random.Next(14, 19);
                            //2
                            name1h_2 = "Cheap Copper ";
                            stamina1h_2 = random.Next(2, 3);
                            armour1h_2 = 0;
                            name1m_2 = "Poor Lether ";
                            stamina1m_2 = random.Next(1, 2);
                            armour1m_2 = 0;
                            name1l_2 = "Poor Cloth ";
                            stamina1l_2 = random.Next(0, 1);
                            armour1l_2 = 0;
                            value1_2 = random.Next(7, 9);

                            name2h_2 = "Copper ";
                            stamina2h_2 = random.Next(3, 4);
                            armour2h_2 = 1;
                            name2m_2 = "Lether ";
                            stamina2m_2 = random.Next(2, 3);
                            armour2m_2 = random.Next(0, 1);
                            name2l_2 = "Cloth ";
                            stamina2l_2 = random.Next(1, 2);
                            armour2l_2 = random.Next(0, 1);
                            value2_2 = random.Next(8, 13);

                            name3h_2 = "Good Copper ";
                            stamina3h_2 = random.Next(4, 5);
                            armour3h_2 = random.Next(1, 2);
                            name3m_2 = "Strong Lether ";
                            stamina3m_2 = random.Next(3, 4);
                            armour3m_2 = random.Next(1, 2);
                            name3l_2 = "Expensive Cloth ";
                            stamina3l_2 = random.Next(3, 4);
                            armour3l_2 = random.Next(0, 1);
                            value3_2 = random.Next(13, 18);
                            break;
                        case Level.LEVEL2:
                            //code...
                            break;
                        case Level.LEVEL3:
                            //code...
                            break;
                        case Level.LEVEL4:
                            //code...
                            break;
                        case Level.LEVEL5:
                            //code...
                            break;
                        case Level.LEVEL6:
                            //code...
                            break;
                        default: //Level 7
                            //code...
                            break;
                    }
                    break;
                case ItemKind.BOOTS:
                    switch (l)
                    {
                        case Level.LEVEL1:
                            //1
                            name1 = "Badly Made ";
                            stamina1h = random.Next(1, 3);
                            armour1h = 0;
                            stamina1m = random.Next(0, 2);
                            armour1m = 0;
                            stamina1l = random.Next(0, 1);
                            armour1l = 0;
                            value1 = random.Next(5, 7);
                            name2 = "";
                            stamina2h = random.Next(2, 4);
                            armour2h = random.Next(0, 1);
                            stamina2m = random.Next(1, 3);
                            armour2m = 0;
                            stamina2l = random.Next(1, 2);
                            armour2l = 0;
                            value2 = random.Next(7, 12);
                            name3 = "Good Made ";
                            stamina3h = random.Next(3, 5);
                            armour3h = random.Next(0, 2);
                            stamina3m = random.Next(2, 4);
                            armour3m = random.Next(0, 1);
                            stamina3l = random.Next(2, 3);
                            armour3l = 0;
                            value3 = random.Next(12, 15);
                            //2
                            name1h_2 = "Cheap Copper ";
                            stamina1h_2 = random.Next(1, 2);
                            armour1h_2 = 0;
                            name1m_2 = "Poor Lether ";
                            stamina1m_2 = random.Next(1, 2);
                            armour1m_2 = 0;
                            name1l_2 = "Poor Cloth ";
                            stamina1l_2 = 1;
                            armour1l_2 = 0;
                            value1_2 = random.Next(6, 8);

                            name2h_2 = "Copper ";
                            stamina2h_2 = random.Next(2, 4);
                            armour2h_2 = random.Next(0, 1);
                            name2m_2 = "Lether ";
                            stamina2m_2 = random.Next(1, 3);
                            armour2m_2 = 0;
                            name2l_2 = "Cloth ";
                            stamina2l_2 = random.Next(1, 2);
                            armour2l_2 = 0;
                            value2_2 = random.Next(7, 11);

                            name3h_2 = "Good Copper ";
                            stamina3h_2 = random.Next(3, 5);
                            armour3h_2 = random.Next(1, 2);
                            name3m_2 = "Strong Lether ";
                            stamina3m_2 = random.Next(2, 4);
                            armour3m_2 = random.Next(0, 1);
                            name3l_2 = "Expensive Cloth ";
                            stamina3l_2 = random.Next(2, 3);
                            armour3l_2 = 0;
                            value3_2 = random.Next(10, 14);
                            break;
                        case Level.LEVEL2:
                            //code...
                            break;
                        case Level.LEVEL3:
                            //code...
                            break;
                        case Level.LEVEL4:
                            //code...
                            break;
                        case Level.LEVEL5:
                            //code...
                            break;
                        case Level.LEVEL6:
                            //code...
                            break;
                        default: //Level 7
                            //code...
                            break;
                    }
                    break;
            }

            switch (random.Next(1, 3))
            {
                case 1:
                    name = name1;
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { stamina = stamina1h; armour = armour1h; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { stamina = stamina1m; armour = armour1m; }
                    else { stamina = stamina1l; armour = armour1l; }
                    value = value1;
                    break;
                case 2:
                    name = name2;
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { stamina = stamina2h; armour = armour2h; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { stamina = stamina2m; armour = armour2m; }
                    else { stamina = stamina2l; armour = armour2l; }
                    value = value2;
                    break;
                case 3:
                    name = name3;
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { stamina = stamina3h; armour = armour3h; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { stamina = stamina3m; armour = armour3m; }
                    else { stamina = stamina3l; armour = armour3l; }
                    value = value3;
                    break;
            }

            switch (random.Next(1, 3))
            {
                case 1:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += name1h_2; stamina += stamina1h_2; armour += armour1h_2; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += name1m_2; stamina += stamina1m_2; armour += armour1m_2; }
                    else { name += name1l_2; stamina += stamina1l_2; armour += armour1l_2; }
                    value += value1_2;
                    break;
                case 2:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += name2h_2; stamina += stamina2h_2; armour += armour2h_2; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += name2m_2; stamina += stamina2m_2; armour += armour2m_2; }
                    else { name += name2l_2; stamina += stamina2l_2; armour += armour2l_2; }
                    value += value2_2;
                    break;
                case 3:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += name3h_2; stamina += stamina3h_2; armour += armour3h_2; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += name3m_2; stamina += stamina3m_2; armour += armour3m_2; }
                    else { name += name3l_2; stamina += stamina3l_2; armour += armour3l_2; }
                    value += value3_2;
                    break;
            }

            switch (ik)
            {
                case ItemKind.HEAD_ARMOUR:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Helmet"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Medium Helmet"; }
                    else { name += "Cap"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.HEAD_ARMOUR);
                case ItemKind.BODY_ARMOUR:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Faulds"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Medium Byrnie"; }
                    else { name += "Robe"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.BODY_ARMOUR);
                case ItemKind.GLOVES:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Gauntlets"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Gloves"; }
                    else { name += "Thin gloves"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.GLOVES);
                case ItemKind.LEGS_ARMOUR:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Legs"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Chausses"; }
                    else { name += "Chausses"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.LEGS_ARMOUR);
                case ItemKind.BOOTS:
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Sabatons"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Rugged Shoes"; }
                    else { name += "Shoes"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.BOOTS);
                default:
                    Console.WriteLine("Something unexpected happend");
                    if (armourKind == ArmourKind.HEAVY_ARMOUR) { name += "Heavy Helmet"; }
                    else if (armourKind == ArmourKind.MEDIUM_ARMOUR) { name += "Medium Helmet"; }
                    else { name += "Cap"; }
                    return new Armour(stamina, 0, 0, 0, 0, 0, 0, armour, name, value, l, armourKind, ItemKind.BODY_ARMOUR);
            }
        }

        public static OffHand GenerateOffHand(Level l)
        {
            int stamina = 0;
            int strenght = 0;
            int agility = 0;
            int intelligence = 0;
            int fireResistance = 0;
            int coldResistance = 0;
            int chaosResistance = 0;
            int armour = 0;

            string name = "";
            int damage = 0;
            int v = 0;

            switch (random.Next(1, 2)) //dagger or shield
            {
                case 1: //Dagger
                    switch (l)
                    {
                        case Level.LEVEL1:
                            switch (random.Next(1, 2))
                            {
                                case 1:
                                    name += "Sharp";
                                    damage = random.Next(1, 2);
                                    break;
                                case 2:
                                    name += "Defensive";
                                    armour = random.Next(1, 2);
                                    break;
                            }
                            break;
                    }
                    name += " Dagger";
                    damage += random.Next(1, 2);
                    v = random.Next(10, 15);

                    return new OffHand(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, v, l, damage, offHandKind:OffHandKind.DAGGER);
                case 2: //shield
                    switch (l)
                    {
                        case Level.LEVEL1:
                            switch (random.Next(1, 1))
                            {
                                case 1:
                                    name += "Defensive";
                                    armour = random.Next(1, 2);
                                    break;

                            }
                            name += " Shield";
                            armour += random.Next(0, 1);
                            v = random.Next(10, 15);
                            break;
                    }
                    return new OffHand(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, v, l, damage, offHandKind: OffHandKind.SHIELD);
                default:
                    Console.WriteLine("Something unexpected happend");
                    return new OffHand(stamina, strenght, agility, intelligence,
                fireResistance, coldResistance, chaosResistance, armour, name, v, l, damage, offHandKind: OffHandKind.DAGGER);
            }

        }
    }
}
