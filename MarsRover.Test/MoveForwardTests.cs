namespace MarsRover.Test;

[TestFixture]
public class MoveForwardTests
{
    [Test]
    public void MoveForwardFacingNorth()
    {
        var rover = new MarsRover(1, 1, Direction.North);
        rover.MoveForward();

        Assert.That(rover.PositionX, Is.EqualTo(1));
        Assert.That(rover.PositionY, Is.EqualTo(2));
    }

    [Test]
    public void MoveForwardFacingSouth()
    {
        var rover = new MarsRover(1, 2, Direction.South);
        rover.MoveForward();

        Assert.That(rover.PositionX, Is.EqualTo(1));
        Assert.That(rover.PositionY, Is.EqualTo(1));
    }
}