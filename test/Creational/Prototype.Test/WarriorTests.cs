namespace Prototype.Test;
public class WarriorTests
{
    [Fact]
    public void Clone_WhenCalled_ShouldReturnShallowCopyWithSameProperties()
    {
        // Arrange
        var warriorPrototype = new Warrior("Conan", "A fierce warrior.");

        // Act
        var clonedWarrior = (Warrior)warriorPrototype.Clone();

        // Assert
        clonedWarrior.Should().NotBeNull();
        clonedWarrior.Name.Should().Be(warriorPrototype.Name);
        clonedWarrior.Description.Should().Be(warriorPrototype.Description);
        clonedWarrior.Should().BeOfType<Warrior>();
    }

    [Fact]
    public void GetDetail_WhenCalled_ShouldReturnFormattedDetailString()
    {
        // Arrange
        var warrior = new Warrior("Conan", "A fierce warrior.");

        // Act
        var details = warrior.GetDetail();

        // Assert
        details.Should().Be("Warrior => Name: Conan - Description: A fierce warrior.");
    }
}
