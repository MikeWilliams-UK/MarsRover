using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class MarsRover
    {
        public enum Direction
        {
            North

        }


        public Direction direction;

        public MarsRover(int x, int y, Direction direction)
        {

            this.direction = direction;
        }


    }
}
