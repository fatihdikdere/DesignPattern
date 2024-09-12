namespace Command;
/// <summary>
/// Base command interface
/// </summary>
public interface ICommand
{
    void Execute();
    void Undo();
}
