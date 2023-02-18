using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit.Heroes.Classes
{
    internal class Witch : Hero
    {
        public Witch(string n) : base(n, 7, 2, 2, 6, 1, 1, 1, 1)
        {
            this.className = "Witch";
            skills.Add(new DealingDamageSkillOneStatScalling("Toxic dart", Stats.INTELIGENCE, 1.5f, DamageType.CHAOS, 10));
        }

        public override void CalculateDamage()
        {
            damage = intelligence * 0.4f;
            if (mainHand != null)
            {
                Weapon weapon = (Weapon)this.mainHand;
                damage += weapon.GetDamage() * intelligence * 0.4f;
            }
            if(this.offHand != null)
            {
                OffHand offHand = (OffHand)this.offHand;
                damage += offHand.GetDamage() * intelligence * 0.4f;
            }
        }

        public override void CalculateHealthPoints()
        {
            maxHealthPoints = stamina * 2;
            this.healthPoints = maxHealthPoints;
        }

        public override void CalculateMana()
        {
            this.maxMana = 12 + intelligence * 2.5f;
            this.mana = maxMana;
        }
    }
}
