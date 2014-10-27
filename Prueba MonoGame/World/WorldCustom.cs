using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World
{
    class WorldCustom : IWorld
    {
        int level;
        string name;
        List<Blocks.IBlock> blocks;

        public WorldCustom(int level, string name, List<Blocks.IBlock> blocks)
        {
            this.level = level;
            this.name = name;
            this.blocks = blocks;
        }
        public WorldCustom()
        {
            blocks = new List<Blocks.IBlock>();
        }
    }
}
