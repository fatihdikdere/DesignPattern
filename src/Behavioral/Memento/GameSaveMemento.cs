namespace Memento;
/// <summary>
/// Memento class
/// </summary>
public class GameSaveMemento(int health, int position, List<string> inventory)
{
    public int Health { get; } = health;
    public int Position { get; } = position;
    public List<string> Inventory { get; } = inventory;
}
