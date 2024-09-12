namespace Command;
/// <summary>
/// Invoker class 
/// </summary>
public class CommandInvoker
{
    private readonly List<ICommand> commands = [];
    public void AddCommand(ICommand command)
        => commands.Add(command);
    public void ExecuteCommands()
    {
        foreach (var command in commands)
        {
            command.Execute();
        }
    }
    public void UndoLastCommand()
    {
        if (commands.Count <= 0)
        {
            return;
        }

        var lastCommand = commands[^1];

        lastCommand.Undo();
    }
}