using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Items;
using static System.Net.Mime.MediaTypeNames;

namespace TextBasedRPG.Classes.Unit.Monsters
{
    internal class MonsterBuilder
    {
        private Monster _monster = new Monster();
        public Monster Build() => _monster;
        public MonsterBuilder Name(string name)
        {
            _monster.SetName(name);
            return this;
        }
        public MonsterBuilder Stamina(int stamina)
        {
            _monster.Stamina = stamina;
            return this;
        }
        public MonsterBuilder Strenght(int strenght)
        {
            _monster.Strenght = strenght;
            return this;
        }
        public MonsterBuilder Agility(int agility)
        {
            _monster.Agility = agility;
            return this;
        }
        public MonsterBuilder Intelligence(int intelligence)
        {
            _monster.Intelligence = intelligence;
            return this;
        }
        public MonsterBuilder Armour(int armour)
        {
            _monster.Armour = armour;
            return this;
        }
        public MonsterBuilder FireResistance(int fireResistance)
        {
            _monster.FireResistance = fireResistance;
            return this;
        }
        public MonsterBuilder ColdResistance(int coldResistance)
        {
            _monster.ColdResistance = coldResistance;
            return this;
        }
        public MonsterBuilder ChaosResistance(int chaosResistance)
        {
            _monster.ChaosResistance = chaosResistance;
            return this;
        }
        public MonsterBuilder Exp(int exp)
        {
            _monster.ExpierienceGiven = exp;
            return this;
        }
        public MonsterBuilder DropList(List<Item> dropList)
        {
            _monster.SetDropList(dropList);
            return this;
        }
        public MonsterBuilder SetModifers(bool fromSt = false, float stMod = 0, bool fromAg = false, float agMod = 0, bool fromInt = false, float intMod = 0)
        {
            if (fromSt)
            {
                _monster.Damage += _monster.Strenght * stMod;
            }
            if (fromAg)
            {
                _monster.Damage += _monster.Agility * agMod;
            }
            if (fromInt)
            {
                _monster.Damage += _monster.Intelligence * intMod;
            }
            return this;
        }


        public MonsterBuilder SetHp()
        {
            _monster.MaxHealthPoints = _monster.Stamina * 2;
            _monster.HealthPoints = _monster.MaxHealthPoints;
            return this;
        }
    }
}
