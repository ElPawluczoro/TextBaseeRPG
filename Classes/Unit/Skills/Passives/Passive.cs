using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.Unit.Skills.Passives
{
    internal class Passive
    {
        private PassivesReleases passivesRelease; public PassivesReleases PassivesRelease { get => passivesRelease; set => passivesRelease = value; }
        private string name; public string Name { get => name; set => name = value; }
        private List<PassiveEffects> effects = new List<PassiveEffects>();

        //parameters
        private Unit healingTarget = null; public Unit HealingTarget { get => healingTarget; set => healingTarget = value; }
        private Unit damageTarget = null; public Unit DamageTarget { get => damageTarget; set => damageTarget = value; }
        private Unit statIncTarget = null; public Unit StatIncTarget { get => statIncTarget; set => statIncTarget = value; }

        private Target healingTargetType = Target.SELF; public Target HealingTargetType { get => healingTargetType; set => healingTargetType = value; }
        private Target damageTargetType = Target.SELF; public Target DamageTargetType { get => damageTargetType; set => damageTargetType = value; }
        private Target statIncTargetType = Target.SELF; public Target StatIncTargetType { get => statIncTargetType; set => statIncTargetType = value; }
        private float healingValue = 0; public float HealingValue { get =>healingValue;  set  => healingValue = value; }

        private float damageValue = 0; public float DamageValue { get => damageValue; set => damageValue = value; }

        private float statValue = 0; public float StatValue { get => statValue; set => statValue = value; }

        private DamageType damageType = DamageType.PHYSICAL; public DamageType DamageType { get => damageType; set => damageType = value; }
        private Stats stat = Stats.STAMINA; public Stats Stat { get => stat; set => stat = value; }

        public Passive()
        {

        }

        public List<PassiveEffects> GetEffects()
        {
            return effects;
        }

        public void SetEffects(PassiveEffects effect)
        {
            effects.Add(effect);
        }

        public void Update(/*Unit target = null, float value = 0, DamageType damageType = DamageType.PHYSICAL, Stats stat = Stats.STAMINA*/)
        {
            if (effects.Contains(PassiveEffects.HEAL))
            {
                healingTarget.HealHealthPoints(healingValue);
            }

            if (effects.Contains(PassiveEffects.DEAL_DAMAGE))
            {
                damageTarget.GetDamage(damageValue, damageType);
            }

            if (effects.Contains(PassiveEffects.INCREASE_STAT))
            {
                int temporrarStatAdded;
                switch (stat)
                {
                    case Stats.STAMINA:
                        statIncTarget.Stamina += (int)statValue;
                        break;
                    case Stats.STRENGHT:
                        statIncTarget.Strenght += (int)statValue;
                        break;
                    case Stats.AGILITY:
                        statIncTarget.Agility += (int)statValue;
                        break;
                    case Stats.INTELIGENCE:
                        statIncTarget.Intelligence += (int)statValue;
                        break;
                }
                temporrarStatAdded = (int)statValue; // idk maybe needed
            }



        }
    }
}
