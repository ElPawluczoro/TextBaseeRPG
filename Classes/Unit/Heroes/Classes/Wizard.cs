using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using System.Runtime.CompilerServices;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Wizard : Hero
    {
        public Wizard(string n) : base(n, 8, 2, 2, 5, 1, 1, 1, 1)
        {
            this.className = "Wizard";
            skills.Add(new DealingDamageSkillOneStatScalling("Fire Dart", Stats.INTELIGENCE, 2, DamageType.FIRE, 10));
        }

        public override void CalculateDamage()
        {
            damage = intelligence * 0.3f;
            if (mainHand != null)
            {
                Weapon weapon = (Weapon)this.mainHand;
                damage += weapon.GetDamage() * intelligence * 0.5f;
            }
            if (this.offHand != null)
            {
                OffHand offHand = (OffHand)this.offHand;
                damage += offHand.GetDamage() * intelligence * 0.5f;
            }
        }

        public override void CalculateHealthPoints()
        {
            maxHealthPoints = stamina * 2.3f;
            this.healthPoints = maxHealthPoints;
        }
        public override void CalculateMana()
        {
            this.maxMana = 15 + intelligence * 2;
            this.mana = maxMana;
        }

    }
}
