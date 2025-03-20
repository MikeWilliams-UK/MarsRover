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



        public Direction direction;

        public MarsRover(int x, int y, Direction direction)
        {

            this.direction = direction;
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
