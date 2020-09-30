using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Pacman : Abstract_Entity
    {

        private static string[] image_files = { "Pacman_None.png", "Pacman_Up.png", "Pacman_Down.png, Pacman_Left, Pacman_Right" };

        private int lives;
        private Direction currentDirection;

        public int Lives { get => lives; set => lives = value; }
        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }

        public Pacman(int row, int column) : base(0, row, column)
        {
            this.currentDirection = Direction.LEFT;
            this.lives = 3;
        }
        public override void Draw(Graphics graphics)
        {
            // drawing the background
            int pointX = base.Column * Map.Tile_Size;
            int pointY = base.Row * Map.Tile_Size;
            int side = Map.Tile_Size;
            Rectangle myBounds = new Rectangle(pointX, pointY, side, side);
            Brush myBrush = new SolidBrush(Color.Black);
            graphics.FillRectangle(myBrush, myBounds);

            // drawing pacman
            pointX = base.Column * Map.Tile_Size;
            pointY = base.Row * Map.Tile_Size;
            side = Map.Tile_Size;
            myBounds = new Rectangle(pointX, pointY, side, side);
            int index = (int)this.currentDirection;
            string file_name = image_files[index];
            Image myImage = Image.FromFile(Map.Path + file_name);
            graphics.DrawImage(myImage, myBounds);
            myImage.Dispose();
        }
    }
    
}
