namespace State.Test;
public class GreenStateTests
{
    [Fact]
    public void ChangeLight_WhenCalled_ShouldSetYellowState()
    {
        // Arrange
        var context = new TrafficLightContext();
        var greenState = new GreenState();

        context.SetState(greenState);

        // Act
        context.ChangeLight();

        // Assert
        context.State.Should().BeOfType<YellowState>();
    }
}
