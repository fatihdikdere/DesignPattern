namespace Command.Test;
public class MySystemTests
{
    [Fact]
    public void StartSystem_WhenMethodCalled_ShouldReturnTrue()
    {
        // Arrange
        var mySystem = new MySystem();
        var systemName = "TestSystem";

        // Act
        var result = mySystem.StartSystem(systemName);

        // Assert
        result.Should().BeTrue();
    }
    [Fact]
    public void StopSystem_WhenMethodCalled_ShouldReturnTrue()
    {
        // Arrange
        var mySystem = new MySystem();
        var systemName = "TestSystem";

        // Act
        var result = mySystem.StopSystem(systemName);

        // Assert
        result.Should().BeTrue();
    }
}
