namespace State.Test;
public class YellowStateTests
{
    [Fact]
    public void ChangeLight_WhenCalled_ShouldSetRedState()
    {
        // Arrange
        var context = new TrafficLightContext();
        var yellowState = new YellowState();

        context.SetState(yellowState);

        // Act
        context.ChangeLight();

        // Assert
        context.State.Should().BeOfType<RedState>();
    }
}
