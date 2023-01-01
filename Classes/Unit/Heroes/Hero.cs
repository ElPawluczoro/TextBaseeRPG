using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Items;
using TextBasedRPG.Classes.Items.Currency;
namespace TextBasedRPG.Classes.Unit
{
    internal abstract class Hero : Unit
    {
        protected List<Item> equipment = new List<Item>();
        protected List<Currency> pocket = new List<Currency>();

        protected string className;

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

        public Hero(int hp, int dmg, string n) : base(hp, dmg)
        {
            this.name = n;

            this.level = Level.LEVEL1;
            this.SetMaxExpieriencePoints();
            this.expieriencePoints = 0;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.Write("Class: " + this.className + "\n" +
                            "Level: " + this.ReturnLevelString() + "\n" +
                            "XP: " + this.GetExpieriencePoints() + "\n" +
                            "Max XP: " + this.maxExpieriencePoints + "\n");
            WriteMethods.WriteSeparator();
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

        public List<Item> GetEquipment()
        {
            return this.equipment;
        }

        public void SetMaxExpieriencePoints()
        {
            this.maxExpieriencePoints = (int)this.level;
        }

        public void EquipItem(int i)
        {
            EquipableItem item = (EquipableItem)this.equipment[i-1];
            ItemKind[] armours = { ItemKind.HEAD_ARMOUR, ItemKind.BODY_ARMOUR, 
                                    ItemKind.GLOVES, ItemKind.LEGS_ARMOUR, ItemKind.BOOTS};
            
            if(item.GetItemKind() == ItemKind.WEAPON)
            {
                this.mainHand = item;
                this.damage += item.GetDamage();
                this.RemoveFromEquipment(i);
            }else if (item.GetItemKind() == ItemKind.OFF_HAND)
            {
                this.offHand = item;
                this.damage += item.GetDamage();
                this.armour += item.GetArmour();
                this.healthPoints += item.GetHealthPoints();
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
                this.armour += item.GetArmour();
                this.healthPoints += item.GetHealthPoints();
                this.damage += item.GetDamage();
                this.RemoveFromEquipment(i);
            }
        }

        public void UnequipItem(ItemKind i)
        {
            ItemKind[] armours = { ItemKind.HEAD_ARMOUR, ItemKind.BODY_ARMOUR,
                                    ItemKind.GLOVES, ItemKind.LEGS_ARMOUR, ItemKind.BOOTS};

            if (i == ItemKind.WEAPON)
            {
                this.damage -= this.mainHand.GetDamage();
                this.AddToEquipment(this.mainHand);
                this.mainHand = null;
            }
            else if (i == ItemKind.OFF_HAND)
            {
                this.damage -= this.offHand.GetDamage();
                this.armour -= this.offHand.GetArmour();
                this.healthPoints -= this.offHand.GetHealthPoints();
                this.AddToEquipment(this.offHand);
                this.offHand = null;
            }
            else if (armours.Contains(i))
            {
                EquipableItem item = null;
                switch (i)
                {
                    case ItemKind.HEAD_ARMOUR:
                        item = this.head;
                        this.head = null;
                        break;
                    case ItemKind.BODY_ARMOUR:
                        item = this.body;
                        this.body = null;
                        break;
                    case ItemKind.GLOVES:
                        item = this.gloves;
                        this.gloves = null;
                        break;
                    case ItemKind.LEGS_ARMOUR:
                        item = this.legs;
                        this.legs = null;
                        break;
                    case ItemKind.BOOTS:
                        item = this.boots;
                        this.boots = null;
                        break;
                }
                this.armour -= item.GetArmour();
                this.healthPoints -= item.GetHealthPoints();
                this.AddToEquipment(item);
            }
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
            equipment.Add(item);
        }

        public void RemoveFromEquipment(int i)
        {
            equipment.RemoveAt(i-1);
        }

        public void DisplayEquipment()
        {
            ItemKind[] armours = { ItemKind.HEAD_ARMOUR, ItemKind.BODY_ARMOUR,
                                    ItemKind.GLOVES, ItemKind.LEGS_ARMOUR, ItemKind.BOOTS};

            int i = 0;
            Console.Write(this.name + "equipment:\n");
            foreach(Item item in equipment)
            {
                i++;
                Console.Write(i + "." + item.GetName());
                if (item.GetItemKind() == ItemKind.LOOT_OBJECT)
                {
                    LootObject lootItem;
                    lootItem = (LootObject)item;
                    Console.Write(" (" + lootItem.GetQuantity() + ")\n");
                }
                else if (item.GetItemKind() == ItemKind.WEAPON)
                {
                    EquipableItem eqItem;
                    eqItem = (EquipableItem)item;
                    Console.Write(" d" + eqItem.GetDamage() + "\n");
                }
                else if (armours.Contains(item.GetItemKind()))
                {
                    EquipableItem eqItem;
                    eqItem = (EquipableItem)item;
                    Console.Write(" a" + eqItem.GetArmour() + " hp" + eqItem.GetHealthPoints() + "\n");
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








    }
}



























