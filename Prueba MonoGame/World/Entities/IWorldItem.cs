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

namespace Prueba_MonoGame.World.Entities
{
    public interface IWorldItem
    {
        string getName();
        Rectangle getBounds();
        void setBounds(Rectangle pos);
        Texture2D getTexture();
        void Update();
    }
}
