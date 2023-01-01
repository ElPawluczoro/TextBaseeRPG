using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.Armours
{
    internal class HeadArmour : Armour
    {
        public HeadArmour(int a, int hp, string n, int v, Level rq, ArmourKind ak) : base(a, hp, n, v, rq, ak)
        {
            this.kind = ItemKind.HEAD_ARMOUR;
        }
    }
}
