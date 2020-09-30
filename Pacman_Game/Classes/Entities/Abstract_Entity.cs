using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Entities
{
    public abstract class Abstract_Entity
    {
        private int score;
        private int row;
        private int column;
        private Color entityColor;

        protected Abstract_Entity()
        {
        }

        protected Abstract_Entity(int score, int row, int column)
        {
            this.score = score;
            this.row = row;
            this.column = column;
            this.entityColor = Color.White;
        }

        public int Score { get => score; set => score = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public Color EntityColor { get => entityColor; set => entityColor = value; }

        public abstract void Draw(Graphics graphics);
    }


    

}