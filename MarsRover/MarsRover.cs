namespace MarsRover
{
    public class MarsRover
    {
        public enum Direction
        {
            North,
            West,
            East
        }

        public int Y { get; set; }


        public Direction direction;

        public MarsRover(int x, int y, Direction direction)
        {
            Y = y;
            this.direction = direction;
        }

        public void MoveForward()
        {
            if (direction == Direction.North)
            {
                Y++;
            }
        }


        public void TurnLeft()
        {
            if (direction == Direction.East)
            {
                direction = Direction.North;
            }
            else
            {
                direction = Direction.West;
            }

        }
    }
}
