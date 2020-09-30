using Pacman_Game.Classes;
using Pacman_Game.Classes.Entities;
using Pacman_Game.Classes.PathFinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameManager.StartGame();
            this.pictureBox1.Height = Map.MaxRows * Map.Tile_Size;
            this.pictureBox1.Width = Map.MaxColumns * Map.Tile_Size;
            this.Height = Map.MaxRows * Map.Tile_Size;
            this.Width = Map.MaxColumns * Map.Tile_Size;
            this.ClientSize = new Size(Width, Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Abstract_Entity obj in Map.entities)
            {
                obj.Draw(e.Graphics);
            }
        }
    }
}
