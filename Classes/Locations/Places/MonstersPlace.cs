using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Unit.Monsters;

namespace TextBasedRPG.Classes.Locations.Places
{
    internal class MonstersPlace : Place
    {
        protected List<string> _monsters;
        public List<string> monsters { get { return _monsters; } set { _monsters = value; } }

        public MonstersPlace(string name, List<string> monserts)
        {
            this.monsters = monserts;
            this._name = name;
            this._placeKind = PlaceKind.MONSTER_PLACE;
        }


        
    }
}
