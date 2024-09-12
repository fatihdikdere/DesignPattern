namespace Command.Test;
/// <summary>
/// Tests can be written for the conditions of no commands
/// </summary>
public class CommandInvokerTests
{
    [Fact]
    public void ExecuteCommands_WhenCommandsExists_ShouldInvokeExecuteOnAllCommands()
    {
        // Arrange
        var commandInvoker = new CommandInvoker();
        var command1 = new MockCommand();
        var command2 = new MockCommand();
        commandInvoker.AddCommand(command1);
        commandInvoker.AddCommand(command2);

        // Act
        commandInvoker.ExecuteCommands();

        // Assert
        command1.WasExecuted.Should().BeTrue();
        command2.WasExecuted.Should().BeTrue();
    }

    [Fact]
    public void UndoLastCommand_WhenCommandsExists_ShouldInvokeUndoOnLastCommand()
    {
        // Arrange
        var commandInvoker = new CommandInvoker();
        var command1 = new MockCommand();
        var command2 = new MockCommand();
        commandInvoker.AddCommand(command1);
        commandInvoker.AddCommand(command2);

        // Act
        commandInvoker.UndoLastCommand();

        // Assert
        command1.WasUndone.Should().BeFalse();
        command2.WasUndone.Should().BeTrue();
    }
}