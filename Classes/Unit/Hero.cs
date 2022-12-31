using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
namespace TextBasedRPG.Classes.Unit
{
    internal abstract class Hero : Unit
    {
        protected Item[] equipment;
        protected Currency[] pocket;

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

        public Item[] GetEquipment()
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
    }
}



























