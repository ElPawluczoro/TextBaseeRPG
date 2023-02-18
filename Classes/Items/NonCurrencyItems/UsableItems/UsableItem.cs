using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items.NonCurrencyItems.UsableItems
{
    internal class UsableItem : NonCurrencyItem
    {
        Effects effect;
        float power;


        public UsableItem(string name, Effects effect, float power, int value)
        {
            itemKind = ItemKind.USABLE_ITEM;
            this.name = name;
            this.effect = effect;
            this.power = power;
            this.value = value;
        }

        public void UseEffect(Hero h)
        {
            switch (effect)
            {
                case Effects.RESTORE_HP:
                    h.RestoreHP(power);
                    Console.WriteLine("You restored " + power + " HP");
                    break;
            }
        }





    }
}
