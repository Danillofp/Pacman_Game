using Pacman_Game.Classes.Entities;
using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes
{
    public static class GameManager
    {
        public static Pacman pacman;
        static GameManager()
        {
            pacman = new Pacman(29, 26);
        }
        

        public static void StartGame()
        {
            Map.LoadData();
            
        }
    }
}
