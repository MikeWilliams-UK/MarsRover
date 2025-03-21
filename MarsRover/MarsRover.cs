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

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Direction CurrentDirection;

        public MarsRover(int positionX, int positionY, Direction currentDirection)
        {
            PositionX = positionX;
            PositionY = positionY;
            CurrentDirection = currentDirection;
        }

        public void MoveForward()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    PositionY++;
                    break;

                case Direction.East:
                    PositionX++;
                    break;

                case Direction.South:
                    PositionY--;
                    break;

                case Direction.West:
                    PositionX--;
                    break;
            }
        }

        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => CurrentDirection
            };
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => CurrentDirection
            };
        }

        public void ExecuteCommands(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'F':
                        MoveForward();
                        break;

                    case 'L':
                        TurnLeft();
                        break;

                    case 'R':
                        TurnRight();
                        break;

                    case 'Q':
                        ShowPostion();
                        break;
                }
            }
        }

        private void ShowPostion()
        {
            Console.WriteLine($"Rover at {PositionX}, {PositionY} facing {CurrentDirection}");
        }
    }
}