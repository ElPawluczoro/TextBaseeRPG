using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems;
using TextBasedRPG.Classes.Items.NonCurrencyItems.EquipableItems.OffHands;
using TextBasedRPG.Classes.Unit.Skills;

namespace TextBasedRPG.Classes.Unit.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string n) : base(n, 10, 5, 3, 2, 3, 2, 2, 2)
        {
            className = "Warrior";
            skills.Add(new DealingDamageSkillOneStatScalling("Heavy Hit", Stats.STRENGHT, 1.3f, DamageType.PHYSICAL, 10));
        }

        public override void CalculateDamage()
        {
            this.damage = this.strenght * 0.6f;
            if (this.mainHand != null)
            {
                Weapon weapon = (Weapon)this.mainHand;
                damage +=weapon.GetDamage() * strenght * 1.1f;
            }
            if (offHand != null)
            {
                OffHand offHand = (OffHand)this.offHand;
                damage += offHand.GetDamage() * strenght * 1.1f;
            }


        }

        public override void CalculateHealthPoints()
        {
            maxHealthPoints = stamina * 3;
            this.healthPoints = maxHealthPoints;
        }

        public override void CalculateMana()
        {
            this.maxMana = 6 + intelligence * 1.5f;
            this.mana = maxMana;
        }

    }
}
