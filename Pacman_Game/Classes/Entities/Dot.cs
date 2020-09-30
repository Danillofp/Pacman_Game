using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Dot:Abstract_Entity
    {
        public Dot(int row, int column) : base(10, row, column)
        {
            
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

            //drawing the dot
            int dotPointX = pointX + (2* Map.Tile_Size)/5;
            int dotPointY = pointY + (2* Map.Tile_Size)/5;
            int dotSide = Map.Tile_Size / 5;
            Rectangle dotBounds = new Rectangle(dotPointX, dotPointY, dotSide, dotSide);
            myBrush = new SolidBrush(base.EntityColor);
            graphics.FillEllipse(myBrush, dotBounds);

            myBrush.Dispose();
        }
    }
}
