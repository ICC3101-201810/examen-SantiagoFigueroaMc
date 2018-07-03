using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace PacMan
{
    public partial class GameView : Form
    {
        public string PlayerName { get; set; }
        public int PlayerPoints { get; set; }
        Random rnd = new Random();
        PacManModel pacMan;
        PhantomModel[] phantoms;

        public GameView()
        {
            InitializeComponent();

            #region Crear Jugador
            pacMan = new PacManModel();
            pacMan.x_value = rnd.Next(1, 900 - 16);
            pacMan.y_value = rnd.Next(1, 900 - 16);
            #endregion

            #region Crear fantasmas
            phantoms = new PhantomModel[]
            {
                new PhantomModel()
                {
                    Color = "Pink",
                    x_value = rnd.Next(1, 900 - 16),
                    y_value = rnd.Next(1, 900 - 16)
                },
                new PhantomModel()
                {
                    Color = "Red",
                    x_value = rnd.Next(1, 900 - 16),
                    y_value = rnd.Next(1, 900 - 16)
                }
            };
            #endregion
            
            

        }

        private void GameView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                pacMan.x_speed = 0;
                pacMan.y_speed = -1;
            }
            if (e.KeyData == Keys.Down)
            {
                pacMan.x_speed = 0;
                pacMan.y_speed = 1;
            }
            if (e.KeyData == Keys.Left)
            {
                pacMan.x_speed = -1;
                pacMan.y_speed = 0;
            }
            if (e.KeyData == Keys.Right)
            {
                pacMan.x_speed = 1;
                pacMan.y_speed = 0;
            }
        }

    }
}
