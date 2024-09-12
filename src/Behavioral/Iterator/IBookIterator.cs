namespace Iterator;
/// <summary>
/// Iterator interface
/// </summary>
public interface IBookIterator
{
    bool HasNext();
    Book? Next();
}
