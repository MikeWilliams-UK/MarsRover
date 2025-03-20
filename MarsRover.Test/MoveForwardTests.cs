namespace MarsRover.Test;

[TestFixture]
public  class MoveForwardTests
{
    [Test]
    public void MoveForwardFacingNorth()
    {
        MarsRover rover = new MarsRover(1, 1, MarsRover.Direction.North);
        rover.MoveForward();

        Assert.That(rover.Y, Is.EqualTo(2));
    }
}
