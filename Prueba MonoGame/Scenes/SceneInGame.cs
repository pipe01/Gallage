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
    public class SceneInGame : IScene
    {

        private SpriteBatch spriteBatch;
        private ContentManager content;
        private GraphicsDevice graphics;
        private WorldOverworld world;

        private Texture2D sprite;

        public SceneInGame(SpriteBatch spriteBatch, ContentManager content, GraphicsDevice graphics)
        {
            this.spriteBatch = spriteBatch;
            this.content = content;
            this.graphics = graphics;
        }

        void IScene.Initialize()
        {
            
        }
        void IScene.LoadContent()
        {
            this.sprite = content.Load<Texture2D>("Gore_54");
            world = new WorldOverworld();
        }
        void IScene.UnloadContent()
        {

        }
        void IScene.Update(GameTime gameTime)
        {

        }
        void IScene.Draw(GameTime gameTime)
        {
            graphics.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // TODO Añadir codigo de dibujo 'SceneInGame:Draw'

            spriteBatch.End();
        }

        List<IEntity> IScene.getElements()
        {
            // TODO Añadir return 'SceneInGame:getElements'
            return null;
        }
        IWorld IScene.getWorld(int level)
        {
            return (IWorld) world;
        }

    }
}
