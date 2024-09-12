namespace Memento.Test;
public class GameTests
{
    [Fact]
    public void SetHealth_WhenCalled_ShouldUpdateHealth()
    {
        // Arrange
        var game = new Game(100, 0);

        // Act
        game.SetHealth(50);

        // Assert
        game.ToString().Should().Contain("Health: 50");
    }

    [Fact]
    public void SetPosition_WhenCalled_ShouldUpdatePosition()
    {
        // Arrange
        var game = new Game(100, 0);

        // Act
        game.SetPosition(10);

        // Assert
        game.ToString().Should().Contain("Position: 10");
    }

    [Fact]
    public void AddToInventory_WhenCalled_ShouldAddItemToInventory()
    {
        // Arrange
        var game = new Game(100, 0);

        // Act
        game.AddToInventory("Sword");

        // Assert
        game.ToString().Should().Contain("Inventory: Sword");
    }

    [Fact]
    public void Save_WhenCalled_ShouldCreateGameSaveMemento()
    {
        // Arrange
        var game = new Game(100, 10);

        game.AddToInventory("Sword");

        // Act
        var memento = game.Save();

        // Assert
        memento.Health.Should().Be(100);
        memento.Position.Should().Be(10);
        memento.Inventory.Should().Contain("Sword");
    }

    [Fact]
    public void Load_WhenCalledWithMemento_ShouldRestoreGameState()
    {
        // Arrange
        var game = new Game(100, 0);
        var memento = new GameSaveMemento(50, 20, ["Sword", "Shield"]);

        // Act
        game.Load(memento);

        // Assert
        game.ToString().Should().Be("Health: 50, Position: 20, Inventory: Sword, Shield");
    }
}
