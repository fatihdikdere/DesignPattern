namespace Memento;
/// <summary>
/// Caretaker class
/// </summary>
public class GameSaveManager
{
    private readonly Stack<GameSaveMemento> saveHistory = new();
    public Stack<GameSaveMemento> SaveHistory => saveHistory;
    public void SaveGame(Game game)
    {
        saveHistory.Push(game.Save());
        Console.WriteLine("Game saved");
    }
    public void LoadLastSave(Game game)
    {
        if (saveHistory.Count <= 0)
        {
            return;
        }

        game.Load(saveHistory.Pop());
        Console.WriteLine("Game loaded");
    }
}
