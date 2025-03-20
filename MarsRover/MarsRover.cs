namespace MarsRover
{
    public class MarsRover
    {
        public enum Direction
        {
            North,
            West
        }



        public Direction direction;

        public MarsRover(int x, int y, Direction direction)
        {

            this.direction = direction;
        }


        public void TurnLeft()
        {

            direction = Direction.West;

        }
    }
}
