using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Booster:Abstract_Entity
    {
        public Booster(int row, int column) : base(50, row, column)
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

            //drawing the booster
            int dotPointX = pointX + (Map.Tile_Size / 4);
            int dotPointY = pointY + (Map.Tile_Size / 4);
            int dotSide = Map.Tile_Size / 2;
            Rectangle dotBounds = new Rectangle(dotPointX, dotPointY, dotSide, dotSide);
            myBrush = new SolidBrush(base.EntityColor);
            graphics.FillEllipse(myBrush, dotBounds);

            myBrush.Dispose();
        }
    }
}
