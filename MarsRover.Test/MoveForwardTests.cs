namespace MarsRover.Test;

[TestFixture]
public class MoveForwardTests
{
    [Test]
    public void MoveForwardFacingNorth()
    {
        MarsRover rover = new MarsRover(1, 1, MarsRover.Direction.North);
        rover.MoveForward();

        Assert.That(rover.PositionY, Is.EqualTo(2));
    }

    [Test]
    public void MoveForwardFacingSouth()
    {
        MarsRover rover = new MarsRover(1, 2, MarsRover.Direction.South);
        rover.MoveForward();

        Assert.That(rover.PositionY, Is.EqualTo(1));
    }
}