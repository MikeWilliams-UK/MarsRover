namespace MarsRover.Test
{
    public class RoverDirectionTests
    {
        [TestCase(Direction.North, Direction.West)]
        [TestCase(Direction.East, Direction.North)]
        public void TurnLeftFromGivenDirection(Direction direction, Direction expectedDirection)
        {
            var marsRover = new MarsRover(0, 0, direction);

            marsRover.TurnLeft();

            Assert.That(marsRover.CurrentDirection, Is.EqualTo(expectedDirection));
        }
    }
}