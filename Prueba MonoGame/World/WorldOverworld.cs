using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World
{
    public class WorldOverworld : IWorld
    {

        private List<Blocks.IBlock> blocks = new List<Blocks.IBlock>();

        int IWorld.getLevel()
        {
            return 0;
        }

        string IWorld.getName()
        {
            return "Overworld";
        }

        public List<Blocks.IBlock> getItems()
        {
            return this.blocks;
        }

    }
}
