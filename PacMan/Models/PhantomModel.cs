using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhantomModel : IPlayer
    {
        public string Color { get; set; }
        public int x_value { get; set; }
        public int y_value { get; set; }

        public int x_speed { get; set; }
        public int y_speed { get; set; }

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
