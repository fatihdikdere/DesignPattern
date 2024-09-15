namespace Facade.Test;
public class GraphicEngineTests
{
    [Fact]
    public void IsGraphicEnough_WhenMethodCalled_ShouldReturnTrue()
    {
        // Arrange
        var graphicEngine = new GraphicEngine();

        // Act
        var result = graphicEngine.IsGraphicEnough();

        // Assert
        result.Should().BeTrue();
    }
}
