using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World
{
    public class WorldOverworld : IWorld
    {

        private List<World.Entities.IWorldItem> items = new List<Entities.IWorldItem>();

        int IWorld.getLevel()
        {
            return 0;
        }

        string IWorld.getName()
        {
            return "Overworld";
        }

        public List<Entities.IWorldItem> getItems()
        {
            return this.items;
        }

    }
}
