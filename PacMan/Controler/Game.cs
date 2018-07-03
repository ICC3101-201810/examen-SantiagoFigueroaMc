using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controler
{
    class Game
    {
        public string PlayerName { get; set; }
        public int PlayerPoints { get; set; }
        Random rnd = new Random();
        PacManModel pacMan;
        PhantomModel[] phantoms;

        public void StartNewGame(string playername = "player 1")
        {
            #region Crear Jugador
            pacMan = new PacManModel();
            pacMan.x_value = rnd.Next(1, 900);
            pacMan.y_value = rnd.Next(1, 900);
            #endregion

            #region Crear fantasmas
            phantoms = new PhantomModel[]
            {
                new PhantomModel()
                {
                    Color = "Pink",
                    x_value = rnd.Next(1,900),
                    y_value = rnd.Next(1, 900)
                },
                new PhantomModel()
                {
                    Color = "Red",
                    x_value = rnd.Next(1,900),
                    y_value = rnd.Next(1, 900)
                }
            };
            #endregion

            while (pacMan.IsAlive)
            {

            }
        }
    }
}
