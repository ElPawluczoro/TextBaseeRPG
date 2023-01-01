using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours
{
    internal class ArmourMethods
    {
        public static string ArmourKindToString(ArmourKind ak)
        {
            if(ak == ArmourKind.LIGHT_ARMOUR) return "Light Armour";
            else if(ak == ArmourKind.MEDIUM_ARMOUR) return "Medium Armour";
            else return "Heavy Armour";
        }
    }
}
