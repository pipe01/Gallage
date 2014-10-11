using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_MonoGame.World
{
    public class WorldOverworld : IWorld
    {
        int IWorld.getLevel()
        {
            return 0;
        }

        string IWorld.getName()
        {
            return "Overworld";
        }

        List<Entities.IEntity> getEntities()
        {
            return null;
        }

    }
}
