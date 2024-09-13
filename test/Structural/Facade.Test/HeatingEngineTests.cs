namespace Facade.Test;
public class HeatingEngineTests
{
    [Fact]
    public void IsHeatAverage_WhenMethodCalled_ShouldReturnTrue()
    {
        // Arrange
        var heatingEngine = new HeatingEngine();

        // Act
        var result = heatingEngine.IsHeatAverage();

        // Assert
        result.Should().BeTrue();
    }
}
