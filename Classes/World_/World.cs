using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Locations;
using TextBasedRPG.Classes.Locations.Places;

namespace TextBasedRPG.Classes.World_
{
    internal class World
    {
        public List<Location> worldLocations = new List<Location>();
        private Time time = new Time(0, 0, 0); public Time Time { get => time; set => time = value; }

        public World()
        {

        }

        public void AddLocation(Location location)
        {
            worldLocations.Add(location);
        }


    }
}
