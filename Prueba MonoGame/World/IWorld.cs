using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World
{
    public interface IWorld
    {
        int getLevel();
        string getName();
        List<Blocks.IBlock> getBlocks();
    }
}
