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
    class Player : IEntity
    {

        private Vector2 pos;

        string IEntity.getName()
        {
            return "Player";
        }
        Vector2 IEntity.getPos()
        {
            return this.pos;
        }
        void IEntity.setPos(Vector2 pos)
        {
            this.pos = pos;
        }
        void IEntity.addPos(Vector2 add)
        {
            this.pos.X += add.X;
            this.pos.Y += add.Y;
        }
        Texture2D IEntity.getTexture()
        {
            return Game1.contentMgr.Load<Texture2D>("Gore_54");
        }
        void IEntity.Update()
        {
            
        }
    }
}
