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

    }
}