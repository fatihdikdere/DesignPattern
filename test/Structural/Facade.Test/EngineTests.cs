namespace Facade.Test;
public class EngineTests
{
    [Fact]
    public void NewInstance_WhenCreated_ShouldImplementIEngine()
    {
        // Arrange
        var engine = new Engine();

        // Act

        //Assert
        engine.Should().BeAssignableTo<IEngine>();
    }
}
