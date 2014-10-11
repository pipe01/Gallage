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
using Prueba_MonoGame.World.Entities.Player;
using Prueba_MonoGame.World.Entities;
using Prueba_MonoGame.World;

namespace Prueba_MonoGame.Scenes
{
    public interface IScene
    {
        void Initialize();
        void LoadContent();
        void UnloadContent();
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);
        List<IEntity> getElements();
        IWorld getWorld(int level);
    }
}
