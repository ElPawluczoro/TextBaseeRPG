using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Skills.Passives
{
    internal class PassiveBuilder
    {
        private Passive _passive = new Passive();
        public Passive Build() => _passive;

        public PassiveBuilder Name(string name)
        {
            _passive.Name = name;
            return this; 
        }

        public PassiveBuilder PassivesRelease(PassivesReleases release)
        {
            _passive.PassivesRelease = release;
            return this;    
        }

        public PassiveBuilder AddHealingEffect(float value, Unit target, Target targetType)
        {
            _passive.SetEffects(PassiveEffects.HEAL);
            _passive.HealingValue = value;
            _passive.HealingTarget = target;
            _passive.HealingTargetType = targetType;
            return this;
        }

        public PassiveBuilder AddDamageEffect(float value, Unit target, DamageType damageType, Target targetType)
        {
            _passive.SetEffects(PassiveEffects.DEAL_DAMAGE);
            _passive.DamageValue = value;
            _passive.DamageTarget = target;
            _passive.DamageType = damageType;
            _passive.DamageTargetType = targetType;
            return this;
        }

        public PassiveBuilder AddStatIncEffect(float value, Unit target, Stats stat, Target targetType)
        {
            _passive.SetEffects(PassiveEffects.INCREASE_STAT);
            _passive.StatValue = value;
            _passive.StatIncTarget = target;
            _passive.Stat = stat;
            _passive.StatIncTargetType = targetType;
            return this;
        }
    }
}
