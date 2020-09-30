using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Fruits:Abstract_Entity
    {
        private static string[] image_files = { "Fruit_Apple.png", "Fruit_Cherry.png", "Fruit_Strawberry.png" };

        private string file_name;
        public Fruits(int row, int column) : base(100, row, column)
        {
            int count = Fruits.image_files.Length;
            int index = RNG.Get_Instance().Next(0, count);
            this.file_name = Fruits.image_files[index];
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

            // drawing the fruit
            pointX = base.Column * Map.Tile_Size;
            pointY = base.Row * Map.Tile_Size;
            side = Map.Tile_Size;
            myBounds = new Rectangle(pointX, pointY, side, side);
            Image myImage = Image.FromFile(Map.Path + this.file_name);
            graphics.DrawImage(myImage, myBounds);
            myImage.Dispose();
        }
    }
}
