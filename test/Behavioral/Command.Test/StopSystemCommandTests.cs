namespace Command.Test;
public class StopSystemCommandTests
{
    [Fact]
    public void Execute_WhenMethodCalled_ShouldCallStopSystem()
    {
        //Arrgance
        var stopSystemCommandMock = new Mock<StopSystemCommand>(It.IsNotNull<MySystem>(), It.IsAny<string>());
        var stopSystemCommand = stopSystemCommandMock.Object;

        // Act
        stopSystemCommand.Execute();

        // Assert
        stopSystemCommandMock.Verify(x => x.Execute(), Times.Once());
    }
    [Fact]
    public void Undo_WhenMethodCalled_ShouldCallStartSystem()
    {
        // Arrgance
        var stopSystemCommandMock = new Mock<StopSystemCommand>(It.IsNotNull<MySystem>(), It.IsAny<string>());
        var stopSystemCommand = stopSystemCommandMock.Object;

        // Act
        stopSystemCommand.Undo();

        // Assert
        stopSystemCommandMock.Verify(x => x.Undo(), Times.Once());
    }
}
