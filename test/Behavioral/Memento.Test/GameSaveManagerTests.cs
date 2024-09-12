namespace Memento.Test;
public class GameSaveManagerTests
{
    [Fact]
    public void SaveGame_WhenCalled_ShouldPushGameSaveToHistory()
    {
        // Arrange
        var game = new Game(100, 10);
        var gameSaveManager = new GameSaveManager();

        // Act
        gameSaveManager.SaveGame(game);

        // Assert
        gameSaveManager.SaveHistory.Count.Should().Be(1);
    }

    [Fact]
    public void LoadLastSave_WhenCalled_ShouldRestoreLastSavedGameState()
    {
        // Arrange
        var game = new Game(100, 0);
        var gameSaveManager = new GameSaveManager();

        game.SetHealth(80);
        game.AddToInventory("Sword");

        gameSaveManager.SaveGame(game);

        // Modify the game state
        game.SetHealth(50);
        game.AddToInventory("Shield");

        // Act
        gameSaveManager.LoadLastSave(game);

        // Assert
        game.ToString().Should().Be("Health: 80, Position: 0, Inventory: Sword, Shield");
    }

    [Fact]
    public void LoadLastSave_WhenNoSaveAvailable_ShouldNotChangeGameState()
    {
        // Arrange
        var game = new Game(100, 0);
        var manager = new GameSaveManager();

        // Act
        manager.LoadLastSave(game);

        // Assert
        game.ToString().Should().Be("Health: 100, Position: 0, Inventory: ");
    }
}
