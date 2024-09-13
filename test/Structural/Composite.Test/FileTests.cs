namespace Composite.Test;
public class FileTests
{
    [Fact]
    public void GetSize_WhenCalled_ShouldReturnCorrectSize()
    {
        // Arrange
        var file = new File("TestFile.txt", 1024);

        // Act
        var size = file.GetSize();

        // Assert
        size.Should().Be(1024);
    }

    [Fact]
    public void ToString_WhenCalled_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange
        var file = new File("TestFile.txt", 1024);

        // Act
        var result = file.ToString();

        // Assert
        result.Should().Be("File: TestFile.txt => Size: 1024");
    }
}
