using System;
using System.Collections.Generic;
using System.Linq;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.UsableItems;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit
{
    internal abstract class Hero : Unit
    {
        protected List<NonCurrencyItem> equipment = new List<NonCurrencyItem>();
        protected List<Currency> pocket = new List<Currency>();

        protected List<Skill> skills = new List<Skill>();

        protected string className;

        protected Location location;

        //equiped stuff
        protected EquipableItem head;
        protected EquipableItem body;
        protected EquipableItem gloves;
        protected EquipableItem legs;
        protected EquipableItem boots;
        protected EquipableItem mainHand;
        protected EquipableItem offHand;

        //level
        protected Level level;
        protected int expieriencePoints;
        protected int maxExpieriencePoints;

        public Hero(string name, int stamina, int strenght, int agility, int inteligence, int armour, int fireResistance, int coldResistance, int chaosResistance) : 
            base (name, stamina, strenght, agility, inteligence, armour, fireResistance, coldResistance, chaosResistance)
        {

            this.level = Level.LEVEL1;
            this.SetMaxExpieriencePoints();
            this.expieriencePoints = 0;

            CalculateDamage();
            CalculateHealthPoints();
            CalculateMana();

        }
        public void UpdateStats(bool add, EquipableItem item)
        {
            if (add)
            {
                stamina += item.stamina;
                strenght += item.strenght;
                agility += item.agility;
                intelligence += item.intelligence;
                armour += item.armour;
                fireResistance += item.fireResistance;
                coldResistance += item.coldResistance;
                chaosResistance += item.chaosResistance;
                
            }
            if (!add)
            {
                stamina -= item.stamina;
                strenght -= item.strenght;
                agility -= item.agility;
                intelligence -= item.intelligence;
                armour -= item.armour;
                fireResistance -= item.fireResistance;
                coldResistance -= item.coldResistance;
                chaosResistance -= item.chaosResistance;

            }
            CalculateDamage();
            CalculateHealthPoints();
            CalculateMana();

        }
        public abstract void CalculateDamage();
        public abstract void CalculateHealthPoints();
        public abstract void CalculateMana();

        public override void DisplayInformation()
        {
            Console.WriteLine("Class: " + this.className + "\n" +
                            "Level: " + this.ReturnLevelString() + "\n" +
                            "XP: " + this.GetExpieriencePoints() + "\n" +
                            "Max XP: " + this.maxExpieriencePoints + "\n");
            base.DisplayInformation();
            WriteMethods.WriteSeparator();
        }

        public List<Skill> GetSkills()
        {
            return skills;
        }
        public void SetSkills(List<Skill>  s)
        {
            skills = s;
        }
        public int GetExpieriencePoints()
        {
            return this.expieriencePoints;
        }

        public Level GetLevel() 
        {
            return this.level;
        }

        public int GetMaxExpieriencePoints()
        {
            return this.maxExpieriencePoints;
        }

        public List<NonCurrencyItem> GetEquipment()
        {
            return this.equipment;
        }

        public Location GetLocation()
        {
            return location;
        }

        public void SetLocation(Location location)
        {
            this.location = location;
        }

        public void SetMaxExpieriencePoints()
        {
            this.maxExpieriencePoints = (int)this.level;
        }

        public void EquipItem(int i)
        {
            EquipableItem item = (EquipableItem)this.equipment[i-1];
            ItemKind[] armours = ItemsLists.armours;

            if (item.GetItemKind() == ItemKind.WEAPON)
            {
                Weapon weapon = (Weapon)item;
                this.mainHand = item;
                this.damage += weapon.GetDamage();
                this.RemoveFromEquipment(i);
            }else if (item.GetItemKind() == ItemKind.OFF_HAND)
            {
                OffHand offHandItem = (OffHand)item;
                this.offHand = item;
                this.damage += offHandItem.GetDamage();
                this.RemoveFromEquipment(i);
            }else if (armours.Contains(item.GetItemKind()))
            {
                switch (item.GetItemKind())
                {
                    case ItemKind.HEAD_ARMOUR:
                        this.head = item;
                        break;
                    case ItemKind.BODY_ARMOUR:
                        this.body = item;
                        break;
                    case ItemKind.GLOVES:
                        this.gloves = item;
                        break;
                    case ItemKind.LEGS_ARMOUR:
                        this.legs = item;
                        break;
                    case ItemKind.BOOTS:
                        this.boots = item;
                        break;
                }
                this.RemoveFromEquipment(i);
            }
            UpdateStats(true, item);
            Console.WriteLine("You equiped " + item.GetName());
        }

        public void UnequipItem(ItemKind i)
        {
            ItemKind[] armours = ItemsLists.armours;

            EquipableItem item = null;
            if (i == ItemKind.WEAPON)
            {
                item = (EquipableItem)this.mainHand;
                Weapon weapon = (Weapon)this.mainHand;
                this.damage -= weapon.GetDamage();
                this.AddToEquipment(this.mainHand);
                this.mainHand = null;
            }
            else if (i == ItemKind.OFF_HAND)
            {
                item = (EquipableItem)this.offHand;
                OffHand offHandItem = (OffHand)this.offHand;
                this.damage -= offHandItem.GetDamage();
                this.AddToEquipment(this.offHand);
                this.offHand = null;
            }
            else if (armours.Contains(i))
            {
                NonCurrencyItem itemToEq = null;
                switch (i)
                {
                    case ItemKind.HEAD_ARMOUR:
                        itemToEq = head;
                        item = head;
                        this.head = null;
                        break;
                    case ItemKind.BODY_ARMOUR:
                        itemToEq = body;
                        item = body;
                        this.body = null;
                        break;
                    case ItemKind.GLOVES:
                        itemToEq = gloves;
                        item = gloves;
                        this.gloves = null;
                        break;
                    case ItemKind.LEGS_ARMOUR:
                        itemToEq = legs;
                        item = legs;    
                        this.legs = null;
                        break;
                    case ItemKind.BOOTS:
                        itemToEq = boots;
                        item = boots;   
                        this.boots = null;
                        break;
                }
                this.AddToEquipment(itemToEq);
            }
            UpdateStats(false, item);
        }

        public string ReturnLevelString()
        {
            switch (this.level)
            {
                case Level.LEVEL1:
                    return "1";
                case Level.LEVEL2:
                    return "2";
                case Level.LEVEL3:
                    return "3";
                case Level.LEVEL4:
                    return "4";
                case Level.LEVEL5:
                    return "5";
                case Level.LEVEL6:
                    return "6";
                default:
                    return "7";
            }
        }

        public void GiveExpieriencePoints(int exp)
        {
            if (this.level != Level.LEVEL7)
            {
                this.expieriencePoints += exp;
                if(this.expieriencePoints > this.maxExpieriencePoints)
                {
                    this.expieriencePoints -= maxExpieriencePoints;
                    Console.Write("LEVEL UP!");
                    if (this.level == Level.LEVEL1)
                    {
                        this.level = Level.LEVEL2;
                        Console.Write("1-2\n");
                    }
                    else if (this.level == Level.LEVEL2)
                    {
                        this.level = Level.LEVEL3;
                        Console.Write("2-3\n");
                    }
                    else if (this.level == Level.LEVEL3)
                    {
                        this.level = Level.LEVEL4;
                        Console.Write("3-4\n");
                    }
                    else if (this.level == Level.LEVEL4)
                    {
                        this.level = Level.LEVEL5;
                        Console.Write("4-5\n");
                    }
                    else if (this.level == Level.LEVEL5)
                    {
                        this.level = Level.LEVEL6;
                        Console.Write("5-6\n");
                    }
                    else if (this.level == Level.LEVEL5)
                    {
                        this.level = Level.LEVEL6;
                        Console.Write("5-6\n");
                    }
                    else if (this.level == Level.LEVEL6)
                    {
                        this.level = Level.LEVEL7;
                        Console.Write("6-7\n");
                    }
                    else Console.Write("Something unexpected happend\n");
                    this.SetMaxExpieriencePoints();
                }
            }
        }

        public void AddToEquipment(NonCurrencyItem item)
        {
            if (item.GetItemKind() != ItemKind.LOOT_OBJECT)
            {
                this.equipment.Add(item);
            }
            else
            {
                int i = 0;
                bool exists = false;
                LootObject lo = null;
                LootObject lootObject = null;
                foreach (NonCurrencyItem it in this.equipment)
                {
                    if(it.GetName() == item.GetName() && it.GetItemKind() == ItemKind.LOOT_OBJECT)
                    {
                        exists = true;
                        lo = (LootObject)it;
                        lootObject = (LootObject)item;
                        break;
                    }
                    i++;
                }
                if (exists) this.equipment[i] = new LootObject(lo.GetName(), lo.GetValue(), lo.GetQuantity() + lootObject.GetQuantity());
                else this.equipment.Add(item);
            }
        }

        public void RemoveFromEquipment(int i)
        {
            equipment.RemoveAt(i-1);
        }

        public void DisplayEquipment()
        {
            ItemKind[] armours = ItemsLists.armours;
            

            int i = 0;
            Console.Write(this.name +"'s" + " equipment:\n");
            foreach(Item item in equipment)
            {
                i++;
                Console.Write(i + "." + item.GetName());
                if (item.GetItemKind() == ItemKind.LOOT_OBJECT)
                {
                    LootObject lootItem = (LootObject)item;
                    Console.Write(" (" + lootItem.GetQuantity() + ")\n");
                }
                else if (item.GetItemKind() == ItemKind.WEAPON)
                {
                    Weapon eqItem = (Weapon)item;
                    Console.Write(" d" + eqItem.GetDamage() + "\n");
                }
                else if (armours.Contains(item.GetItemKind()))
                {
                    EquipableItem eqItem = (EquipableItem)item;
                    Console.Write(" a" + eqItem.GetArmour() + "\n");
                }
                else Console.Write("\n");
            }
            WriteMethods.WriteSeparator();
        }

        public void DisplayGear()
        {
            Console.WriteLine("Gear\n");
            Console.Write("Head: "); if (this.head != null) Console.Write(this.head.GetName()); Console.Write("\n");
            Console.Write("Body Armour: "); if (this.body != null) Console.Write(this.body.GetName()); Console.Write("\n");
            Console.Write("Gloves: "); if (this.gloves != null) Console.Write(this.gloves.GetName()); Console.Write("\n");
            Console.Write("Legs: "); if (this.legs != null) Console.Write(this.legs.GetName()); Console.Write("\n");
            Console.Write("Boots: "); if (this.boots != null) Console.Write(this.boots.GetName()); Console.Write("\n");
            Console.Write("Main Hand: "); if (this.mainHand != null) Console.Write(this.mainHand.GetName()); Console.Write("\n");
            Console.Write("Off Hand: "); if (this.offHand != null) Console.Write(this.offHand.GetName()); Console.Write("\n");
            WriteMethods.WriteSeparator();
        }

        public void DisplayPocket()
        {
            Console.WriteLine(this.name + "'s Pocket:");
            foreach(Currency c in this.pocket)
            {
                Console.WriteLine(c.GetName() + " " + c.GetQuantity());
            }
            WriteMethods.WriteSeparator();
        }

        public void AddToPocket(Currency c)
        {
            bool exists = false;
            for(int i = 0; i < this.pocket.Count(); i++)
            {
                if (this.pocket[i].GetCurrencyType() == c.GetCurrencyType())
                {
                    this.pocket[i].AddCurrency(c);
                    exists = true;
                }
                else exists = false;
            }
            if(!exists) this.pocket.Add(c);
        }

        public bool IsCurrencyEnough(Currency c)
        {
            bool exists = false;
            for(int i = 0; i < this.pocket.Count(); i++)
            {
                if (this.pocket[i].GetCurrencyType() == c.GetCurrencyType() && this.pocket[i].GetQuantity() >= c.GetQuantity())
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public void SpendCurrency(Currency c)
        {
            for(int i = 0; i < this.pocket.Count(); i++)
            {
                if (this.IsCurrencyEnough(c))
                {
                    this.pocket[i].SubtractCurrency(c);
                }
                else Console.WriteLine("Not Enough Currency");

            }
        }

        public void UseItem(int i)
        {
            UsableItem usableItem = (UsableItem)equipment[i - 1];
            usableItem.UseEffect(this);
            RemoveFromEquipment(i);
        }








    }
}



























