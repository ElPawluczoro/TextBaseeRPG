using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
