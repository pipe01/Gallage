using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World.Blocks
{
    class BlockRegister
    {
        private Dictionary<int, IBlock> blockList = new Dictionary<int, IBlock>();

        public IBlock getByID(int id)
        {
            return blockList[id];
        }

        public bool registerBlock(int id, IBlock block)
        {
            if (!contains(id, block))
            {
                blockList.Add(id, block);
                return true;
            }
            return false;
        }

        private bool contains(int id, IBlock block)
        {
            if (blockList.ContainsKey(id) && blockList.ContainsValue(block))
            {
                return true;
            }
            return false;
        }

    }
}
