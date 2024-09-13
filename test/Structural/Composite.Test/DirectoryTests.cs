namespace Composite.Test;
public class DirectoryTests
{
    [Fact]
    public void AddItem_WhenCalled_ShouldAddItemToDirectory()
    {
        // Arrange
        var directory = new Directory("TestDirectory");
        var itemMock = new Mock<IFileSystemItem>();

        // Act
        directory.AddItem(itemMock.Object);

        // Assert
        directory.Items.Should().Contain(itemMock.Object);
    }

    [Fact]
    public void RemoveItem_WhenCalled_ShouldRemoveItemFromDirectory()
    {
        // Arrange
        var directory = new Directory("TestDirectory");
        var itemMock = new Mock<IFileSystemItem>();

        directory.AddItem(itemMock.Object);

        // Act
        directory.RemoveItem(itemMock.Object);

        // Assert
        directory.Items.Should().NotContain(itemMock.Object);
    }

    [Fact]
    public void GetSize_WhenCalled_ShouldReturnTotalSizeOfAllItems()
    {
        // Arrange
        var directory = new Directory("TestDirectory");
        var mockFile1 = new Mock<IFileSystemItem>();
        var mockFile2 = new Mock<IFileSystemItem>();

        mockFile1.Setup(f => f.GetSize()).Returns(100);
        mockFile2.Setup(f => f.GetSize()).Returns(200);

        directory.AddItem(mockFile1.Object);
        directory.AddItem(mockFile2.Object);

        // Act
        var totalSize = directory.GetSize();

        // Assert
        totalSize.Should().Be(300);
    }

    [Fact]
    public void ToString_WhenCalled_ShouldReturnCorrectStringRepresentation()
    {
        // Arrange
        var directory = new Directory("TestDirectory");
        var mockFile1 = new Mock<IFileSystemItem>();
        var mockFile2 = new Mock<IFileSystemItem>();

        mockFile1.Setup(f => f.ToString()).Returns("File1.txt => Size: 100");
        mockFile2.Setup(f => f.ToString()).Returns("File2.txt => Size: 200");

        directory.AddItem(mockFile1.Object);
        directory.AddItem(mockFile2.Object);

        var expected =
            "Directory: TestDirectory" + Environment.NewLine +
            Environment.NewLine +
            "File1.txt => Size: 100" + Environment.NewLine +
            "File2.txt => Size: 200" + Environment.NewLine;

        // Act
        var result = directory.ToString();

        // Assert
        result.Should().Be(expected);
    }
}
