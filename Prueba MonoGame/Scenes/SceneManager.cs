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

namespace Prueba_MonoGame.Scenes
{
    class SceneManager
    {
        public Dictionary<string, IScene> scenes = new Dictionary<string, IScene>();

        private IScene activeScene;

        public void switchScene(string sceneID)
        {
            /*foreach (IScene item in scenes.Values)
            {
                item.setSpriteBatch(spriteBatch);
            }*/
            activeScene = scenes[sceneID];
        }

        public IScene getActiveScene()
        {
            return activeScene;
        }

        public void execute(string func, object[] args)
        {
            switch (func)
            {
                case "Initialize":
                    activeScene.Initialize();
                    break;
                case "LoadContent":
                    activeScene.LoadContent();
                    break;
                case "UnloadContent":
                    activeScene.UnloadContent();
                    break;
                case "Update":
                    activeScene.Update((GameTime)args[0]);
                    break;
                case "Draw":
                    activeScene.Draw((GameTime) args[0]);
                    break;
                default:
                    break;
            }
        }

    }
}
