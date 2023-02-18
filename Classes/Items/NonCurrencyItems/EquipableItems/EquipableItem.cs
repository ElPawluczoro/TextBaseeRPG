using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit;

namespace TextBasedRPG.Classes.Items
{
    internal abstract class EquipableItem : NonCurrencyItem
    {
        protected Level requaierdLevel;

        protected int _stamina;
        protected int _strenght;
        protected int _agility;
        protected int _intelligence;
        protected int _fireResistance;
        protected int _coldResistance;
        protected int _chaosResistance;
        protected int _armour;

        public int stamina { get => _stamina; set => _stamina = value; }
        public int strenght { get => _strenght; set => _strenght = value; }
        public int agility { get => _agility; set => _agility = value; }
        public int intelligence { get => _intelligence; set => _intelligence = value; }
        public int fireResistance { get => _fireResistance; set => _fireResistance = value; }
        public int coldResistance { get => _coldResistance; set => _coldResistance = value; }
        public int chaosResistance { get => _chaosResistance; set => _chaosResistance = value; }
        public int armour { get => _armour; set => _armour = value; }

        public EquipableItem(int stamina, int strenght, int agility, int intelligence,
            int fireResistance, int coldResistance, int chaosResistance, int armour,
            string name, int value, Level rq)
        {
            this._stamina = stamina;
            this._strenght = strenght;
            this._agility = agility;
            this._intelligence = intelligence;
            this._fireResistance = fireResistance;
            this._coldResistance = coldResistance;
            this._chaosResistance = chaosResistance;
            this._armour = armour;

            this.name = name;
            this.value = value;
            this.requaierdLevel = rq;
        }

        public int GetArmour()
        {
            return _armour;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Requaierd Level: " + HeroMethods.LevelToInt(this.requaierdLevel));
            if (_stamina != 0) Console.WriteLine("Stamina: " + _stamina);
            if (_strenght != 0) Console.WriteLine("Strength: " + _strenght);
            if (_agility != 0) Console.WriteLine("Agility: " + _agility);
            if (_intelligence != 0) Console.WriteLine("Intelligence: " + _intelligence);
            if (_armour != 0) Console.WriteLine("Armour: " + _armour);
            if (_fireResistance != 0) Console.WriteLine("Fire Resistance: " + _fireResistance);
            if (_coldResistance != 0) Console.WriteLine("Cold Resistance: " + _coldResistance);
            if (_chaosResistance != 0) Console.WriteLine("Chaos Reseistance: " + _chaosResistance);
        }

    }
}
