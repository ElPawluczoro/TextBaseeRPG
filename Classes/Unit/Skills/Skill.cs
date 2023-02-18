using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Skills
{
    internal abstract class Skill
    {
        public string name;
        public abstract bool Use(Unit caster, Unit target = null);

        public abstract void UseSkillMessage(Unit caster, Unit target = null);
        public abstract void ShowInformation();

    }
}
