using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public class Wall: Abstract_Entity
    {
        public Wall(int row, int column): base(0, row, column)
        {
            base.EntityColor = Color.Blue;
        }

        public override void Draw(Graphics graphics)
        {
            int pointX = base.Column * Map.Tile_Size;
            int pointY = base.Row * Map.Tile_Size;
            int side = Map.Tile_Size;
            Rectangle myBounds = new Rectangle(pointX, pointY, side, side);
            Brush myBrush = new SolidBrush(base.EntityColor);
            graphics.FillRectangle(myBrush, myBounds);
            myBrush.Dispose();
        }
    }
}
