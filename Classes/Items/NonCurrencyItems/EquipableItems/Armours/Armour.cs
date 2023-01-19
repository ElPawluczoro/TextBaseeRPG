using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours
{
    internal class Armour :EquipableItem
    {
        protected ArmourKind armourKind;
        public Armour(int stamina, int strength, int agility, int intelligence,
                    int fireResistance, int coldResistance, int chaosResistance, int armour,
                    string name, int value, Level rq, ArmourKind armourKind, ItemKind itemKind)
                    : 
                    base(stamina, strength, agility, intelligence, 
                          fireResistance, coldResistance, chaosResistance, armour,
                          name, value, rq)
        {
            this.armourKind = armourKind;
            this.itemKind = itemKind;
        }

        public ArmourKind GetArmourKind()
        {
            return this.armourKind;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine(ArmourMethods.ArmourKindToString(this.armourKind));
            WriteMethods.WriteSeparator();
        }





    }
}
































