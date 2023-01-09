using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Locations.Places;

namespace TextBasedRPG.Classes.Locations
{
    internal abstract class Place
    {
        protected string _name;
        public string name { get { return _name; } }

        protected PlaceKind _placeKind;
        public PlaceKind placeKind { get { return _placeKind; } }
    }
}
