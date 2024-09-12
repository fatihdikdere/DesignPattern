namespace Memento;
/// <summary>
/// Originator class
/// </summary>
public class Game(int health, int position)
{
    private int health = health;
    private int position = position;
    private List<string> inventory = [];
    public void SetHealth(int health)
    {
        this.health = health;
    }
    public void SetPosition(int position)
    {
        this.position = position;
    }
    public void AddToInventory(string item)
    {
        inventory.Add(item);
    }
    public GameSaveMemento Save()
    {
        return new GameSaveMemento(health, position, inventory);
    }
    public void Load(GameSaveMemento memento)
    {
        health = memento.Health;
        position = memento.Position;
        inventory = new List<string>(memento.Inventory);
    }
    public override string ToString()
    {
        return $"Health: {health}, Position: {position}, Inventory: {string.Join(", ", inventory)}";
    }
}
