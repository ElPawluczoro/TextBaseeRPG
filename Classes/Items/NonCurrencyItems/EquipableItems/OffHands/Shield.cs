using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands
{
    internal class Shield : OffHand
    {
        public Shield(string n, int v, Level rq, int dmg, int hp, int a) : base(n, v, rq, dmg, hp, a)
        {
            this.offHandKind = OffHandKind.SHIELD;
        }
    }
}
