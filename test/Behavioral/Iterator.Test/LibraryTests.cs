namespace Iterator.Test;
public class LibraryTests
{
    [Fact]
    public void AddBook_WhenCalled_ShouldAddBookToLibrary()
    {
        // Arrange
        var library = new Library();
        var book = new Book("Title1", "Author1");

        // Act
        library.AddBook(book);

        // Assert
        var iterator = library.CreateIterator();

        iterator.HasNext().Should().BeTrue();
        iterator.Next().Should().Be(book);
        iterator.HasNext().Should().BeFalse();
    }

    [Fact]
    public void CreateIterator_WhenCalled_ShouldReturnIterator()
    {
        // Arrange
        var library = new Library();
        var book1 = new Book("Title1", "Author1");
        var book2 = new Book("Title2", "Author2");

        library.AddBook(book1);
        library.AddBook(book2);

        // Act
        var iterator = library.CreateIterator();

        // Assert
        iterator.HasNext().Should().BeTrue();
        iterator.Next().Should().Be(book1);
        iterator.HasNext().Should().BeTrue();
        iterator.Next().Should().Be(book2);
        iterator.HasNext().Should().BeFalse();
    }
}
