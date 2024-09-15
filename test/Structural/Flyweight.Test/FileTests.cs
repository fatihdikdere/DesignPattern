namespace Flyweight.Test;
public class FileTests
{
    [Fact]
    public void DisplayIcon_WhenCalled_ShouldCallDisplayMethodOnIconWithFileName()
    {
        // Arrange
        var mockIcon = new Mock<IIcon>();
        var file = new File("document.txt", mockIcon.Object);

        // Act
        file.DisplayIcon();

        // Assert
        mockIcon.Verify(icon => icon.Display("document.txt"), Times.Once);
    }
}
