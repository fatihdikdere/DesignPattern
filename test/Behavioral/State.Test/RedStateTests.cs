namespace State.Test;
public class RedStateTests
{
    [Fact]
    public void ChangeLight_WhenCalled_ShouldSetGreenState()
    {
        // Arrange
        var context = new TrafficLightContext();
        var redState = new RedState();

        context.SetState(redState);

        // Act
        context.ChangeLight();

        // Assert
        context.State.Should().BeOfType<GreenState>();
    }
}
