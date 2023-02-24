using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;

namespace TextBasedRPG.Classes.Locations
{
    internal class Location
    {
        protected string _name;
        public string name { get { return _name; } set { _name = value; } }

        protected List<Place> _places;
        public List<Place> places { get { return _places; } set { _places = value; } }

        protected List<Location> _locationsNear;
        public List<Location> locationsNear { get { return _locationsNear; } set { _locationsNear = value; } }

        public Location(string name, List<Place> places, List<Location> locations)
        {
            this._name = name;
            this._places = places;
            this._locationsNear = locations;
        }

        public Location(string name)
        {
            this.name = name;
            this._places = new List<Place>();
            this._locationsNear = new List<Location>();
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Name: " + this._name + "\nPlaces:");
            foreach(Place place in this._places)
            {
                Console.WriteLine(place.name);
            }
            Console.WriteLine("Locations Near:");
            foreach(Location location in this._locationsNear)
            {
                Console.WriteLine(location.name);
            }
            WriteMethods.WriteSeparator();
        }











    }
}
