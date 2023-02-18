using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit
{
    internal class HeroMethods
    {
        public static int LevelToInt(Level l)
        {
            switch (l)
            {
                case Level.LEVEL1: return 1;
                case Level.LEVEL2: return 2;
                case Level.LEVEL3: return 3;
                case Level.LEVEL4: return 4;
                case Level.LEVEL5: return 5;
                case Level.LEVEL6: return 6;
                default: return 7;
            }
        }

        public static string StatToString(Stats stat)
        {
            switch (stat)
            {
                case Stats.STAMINA: return "stamina";
                case Stats.STRENGHT: return "strength";
                case Stats.AGILITY: return "agility";
                case Stats.INTELIGENCE: return "intelligence";
                default: return "wrong value";
            }
        }

        public static string DamageTypeToString(DamageType damageType)
        {
            switch (damageType)
            {
                case DamageType.PHYSICAL: return "Physical";
                case DamageType.FIRE: return "Fire";
                case DamageType.COLD: return "Cold";
                case DamageType.CHAOS: return "Chaos";
                default: return "Wrong Value";
            }
        }

    }
}
