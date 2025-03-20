namespace MarsRover
{
    public class MarsRover
    {
        public enum Direction
        {
            North

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


    }
}
