namespace Command;
/// <summary>
/// Concrete command
/// </summary>
/// <seealso cref="Command.ICommand" />
public class StartSystemCommand(MySystem mySystem, string systemName) : ICommand
{
    private readonly MySystem mySystem = mySystem;
    private readonly string systemName = systemName;
    public virtual void Execute()
    {
        mySystem.StartSystem(systemName);
    }
    public virtual void Undo()
    {
        mySystem.StopSystem(systemName);
    }
}
