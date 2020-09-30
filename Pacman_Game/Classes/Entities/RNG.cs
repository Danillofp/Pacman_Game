using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class RNG: Random
    {
        private static RNG instance = null;
        private RNG(): base() { }

        public static Random Get_Instance()
        {
            if(instance == null)
            {
                instance = new RNG();
            }
            return instance;
        }
       
    }
}
