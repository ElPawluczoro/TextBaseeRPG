using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours
{
    internal abstract class Armour :EquipableItem
    {
        protected ArmourKind armourKind;
        public Armour(int a, int hp, string n, int v, Level rq, ArmourKind ak) : base(n, v, rq)
        {
            this.armour = a;
            this.healthPoints = hp;
            this.armourKind = ak;
        }

        public ArmourKind GetArmourKind()
        {
            return this.armourKind;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine(ArmourMethods.ArmourKindToString(this.armourKind));
            if (this.armour != 0) Console.WriteLine("Armour: " + this.armour);
            if (this.healthPoints != 0) Console.WriteLine("HP: " + this.healthPoints);
            WriteMethods.WriteSeparator();
        }





    }
}
































