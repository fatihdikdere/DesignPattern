namespace Prototype.Test;
public class GameCharacterTests
{
    [Fact]
    public void GetDetail_WhenCalled_ShouldReturnFormattedDetailString()
    {
        // Arrange
        var testCharacter = new TestCharacter("Hero", "A brave hero.");

        // Act
        var details = testCharacter.GetDetail();

        // Assert
        details.Should().Be("Name: Hero - Description: A brave hero.");
    }
}
