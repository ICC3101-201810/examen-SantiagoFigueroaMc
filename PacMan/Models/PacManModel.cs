using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PacManModel : IPlayer
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsAlive { get; set; }

        public int x_value { get; set; }
        public int y_value { get; set; }

        public int x_speed { get; set; }
        public int y_speed { get; set; }

        public PacManModel(string name)
        {
            Name = name;
            Points = 0;
            IsAlive = true;
        }

        public PacManModel() { }

        public void MoveX()
        {
            x_value += x_speed;
        }

        public void MoveY()
        {
            y_value = y_speed;
        }
    }
}
