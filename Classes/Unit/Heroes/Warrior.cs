﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string n) : base(20, 2, n)
        {
            this.armour = 3;
            this.className = "Warrior";
        }
    }
}
