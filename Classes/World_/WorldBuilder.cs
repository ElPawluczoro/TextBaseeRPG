using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.Locations;

namespace TextBasedRPG.Classes.World_
{
    internal class WorldBuilder
    {
        private World _world = new World();
        public World Build() => _world;
        public WorldBuilder AddLocation(Location location)
        {
            _world.AddLocation(location);
            return this;
        }

        public WorldBuilder AddLocationToLocation(Location location, Location locationToAdd)
        {
            int i = 0;
            foreach (Location loc in _world.worldLocations)
            {
                
                if (loc.name == location.name)
                {
                    _world.worldLocations[i].locationsNear.Add(locationToAdd);
                    return this;
                }
                i++;
            }
            return null;
        }

        public WorldBuilder AddPlaceToLocation(Location location, Place place)
        {
            int i = 0;
            foreach(Location loc in _world.worldLocations)
            {
                
                if(loc.name == location.name)
                {
                    _world.worldLocations[i].places.Add(place);
                    return this;
                }
                i++;
            }
            return null;
        }
    }
}
