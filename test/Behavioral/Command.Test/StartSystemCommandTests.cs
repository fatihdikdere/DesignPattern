namespace Command.Test;
public class StartSystemCommandTests
{
    [Fact]
    public void Execute_WhenMethodCalled_ShouldCallStopSystem()
    {
        //Arrgance
        var startSystemCommandMock = new Mock<StartSystemCommand>(It.IsNotNull<MySystem>(), It.IsAny<string>());
        var startSystemCommand = startSystemCommandMock.Object;

        // Act
        startSystemCommand.Execute();

        // Assert
        startSystemCommandMock.Verify(x => x.Execute(), Times.Once());
    }
    [Fact]
    public void Undo_WhenMethodCalled_ShouldCallStartSystem()
    {
        // Arrgance
        var startSystemCommandMock = new Mock<StartSystemCommand>(It.IsNotNull<MySystem>(), It.IsAny<string>());
        var startSystemCommand = startSystemCommandMock.Object;

        // Act
        startSystemCommand.Undo();

        // Assert
        startSystemCommandMock.Verify(x => x.Undo(), Times.Once());
    }
}
