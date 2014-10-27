using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace Prueba_MonoGame
{
    class Global
    {
        public static Scenes.SceneManager sceneMgr;

        public static World.Blocks.BlockRegister blockReg = new World.Blocks.BlockRegister();

        public static SpriteBatch spriteBatch;

        public static void throwError(string desc, int id)
        {
            MessageBox.Show("Ha ocurrido un error!\n" +
                            "ID: " + id +
                            "Descripción: " + desc + "\n");
        }

    }
}
