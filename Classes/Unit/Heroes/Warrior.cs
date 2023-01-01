using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(int hp, int dmg, string n) : base(hp, dmg, n)
        {
            this.armour = 3;
            this.className = "Warrior";
        }
    }
}
