namespace Command;
/// <summary>
/// Concrete command
/// </summary>
/// <seealso cref="Command.ICommand" />
public class StopSystemCommand(MySystem mySystem, string systemName) : ICommand
{
    private readonly MySystem mySystem = mySystem;
    private readonly string systemName = systemName;
    public virtual void Execute()
    {
        mySystem.StopSystem(systemName);
    }
    public virtual void Undo()
    {
        mySystem.StartSystem(systemName);
    }
}
