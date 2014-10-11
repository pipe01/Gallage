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

namespace Prueba_MonoGame.World.Entities.Player
{
    class Player : IWorldItem
    {

        private Rectangle bounds;

        string IWorldItem.getName()
        {
            return "Player";
        }
        Rectangle IWorldItem.getBounds()
        {
            return this.bounds;
        }
        void IWorldItem.setBounds(Rectangle bounds)
        {
            this.bounds = bounds;
        }
        Texture2D IWorldItem.getTexture()
        {
            return Game1.contentMgr.Load<Texture2D>("Gore_54");
        }
        void IWorldItem.Update()
        {
            
        }
    }
}
