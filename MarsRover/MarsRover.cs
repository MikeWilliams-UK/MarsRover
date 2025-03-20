namespace MarsRover
{
    public class MarsRover
    {
        public enum Direction
        {
            North,
            West,
            East,
            South
        }

        public int yPosition { get; set; }


        public Direction direction;

        public MarsRover(int x, int y, Direction direction)
        {
            yPosition = y;
            this.direction = direction;
        }

        public void MoveForward()
        {
            if (direction == Direction.North)
            {
                yPosition++;
            }
            if (direction == Direction.South)
            {
                yPosition--;
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

        public void TurnRight()
        {
            if (direction == Direction.North)
            {
                direction = Direction.East;
            }
            else if (direction == Direction.East)
            {
                direction = Direction.South;
            }
            else if (direction == Direction.South)
            {
                direction = Direction.West;
            }
            else if (direction == Direction.West)
            {
                direction = Direction.North;
            }
        }
    }
}
