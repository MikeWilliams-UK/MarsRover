namespace MarsRover.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Nothing to do here yet
        }

        [Test]
        public void CreateInitialLocation()
        {
            var marsRover = new MarsRover(1, 1, Direction.North);

            Assert.That(marsRover.CurrentDirection, Is.EqualTo(Direction.North));
        }

        [Test]
        public void RoverFacingNorthTurnsRightToEast()
        {
            var rover = new MarsRover(1, 1, Direction.North);
            rover.TurnRight();

            Assert.That(rover.CurrentDirection, Is.EqualTo(Direction.East));
        }

        [Test]
        public void RoverFacingEastTurnsRightToSouth()
        {
            var rover = new MarsRover(1, 1, Direction.East);
            rover.TurnRight();

            Assert.That(rover.CurrentDirection, Is.EqualTo(Direction.South));
        }

        [Test]
        public void RoverFacingSouthTurnsRightToWest()
        {
            var rover = new MarsRover(1, 1, Direction.South);
            rover.TurnRight();

            Assert.That(rover.CurrentDirection, Is.EqualTo(Direction.West));
        }

        [Test]
        public void RoverFacingWestTurnsRightToNorth()
        {
            var rover = new MarsRover(1, 1, Direction.West);
            rover.TurnRight();

            Assert.That(rover.CurrentDirection, Is.EqualTo(Direction.North));
        }
    }
}