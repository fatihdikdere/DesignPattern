namespace Command.Test;
public class MockCommand : ICommand
{
    public bool WasExecuted { get; private set; }
    public bool WasUndone { get; private set; }
    public void Execute()
    {
        WasExecuted = true;
    }
    public void Undo()
    {
        WasUndone = true;
    }
}
