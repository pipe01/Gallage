using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace Prueba_MonoGame.World.Blocks
{
    class BlockTest : IBlock
    {
        Texture2D IBlock.getTexture()
        {
            return Game1.contentMgr.Load<Texture2D>("Gore_54");
        }

        Vector2 IBlock.getPos()
        {
            return new Vector2(0, 0);
        }

    }
}
