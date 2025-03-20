namespace MarsRover.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestCreateInitialLocation()
        {
            var marsRover = new MarsRover(1, 1, MarsRover.Direction.North);

            NUnit.Framework.Assert.That(marsRover.direction, Is.EqualTo(MarsRover.Direction.North));
        }

        [Test]
        public void RoverFacingNorthTurnsRightToEast()
        {
            var rover = new MarsRover(1, 1, MarsRover.Direction.North);
            rover.TurnRight();

            Assert.That(rover.direction, Is.EqualTo(MarsRover.Direction.East));
        }

        [Test]
        public void RoverFacingEastTurnsRightToSouth()
        {
            var rover = new MarsRover(1, 1, MarsRover.Direction.East);
            rover.TurnRight();

            Assert.That(rover.direction, Is.EqualTo(MarsRover.Direction.South));
        }

        [Test]
        public void RoverFacingSouthTurnsRightToWest()
        {
            var rover = new MarsRover(1, 1, MarsRover.Direction.South);
            rover.TurnRight();

            Assert.That(rover.direction, Is.EqualTo(MarsRover.Direction.West));
        }

        [Test]
        public void RoverFacingWestTurnsRightToNorth()
        {
            var rover = new MarsRover(1, 1, MarsRover.Direction.West);
            rover.TurnRight();

            Assert.That(rover.direction, Is.EqualTo(MarsRover.Direction.North));
        }
    }
}