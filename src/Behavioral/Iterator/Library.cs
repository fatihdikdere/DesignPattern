namespace Iterator;
/// <summary>
/// Concrete collection class
/// </summary>
/// <seealso cref="Iterator.IBookCollection" />
public class Library : IBookCollection
{
    private readonly List<Book> books = [];
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public IBookIterator CreateIterator()
    {
        return new LibraryBookIterator(books);
    }
}
