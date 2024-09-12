namespace Iterator;
/// <summary>
/// ConcreteIterator class
/// </summary>
/// <seealso cref="Iterator.IBookIterator" />
public class LibraryBookIterator(List<Book> books) : IBookIterator
{
    private int position;
    private readonly List<Book> books = books;
    public bool HasNext()
    {
        return position < books.Count;
    }
    public Book? Next()
    {
        return HasNext()
            ? books[position++]
            : null;
    }
}
