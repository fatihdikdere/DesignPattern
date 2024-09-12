namespace Iterator;
/// <summary>
/// Collection interface
/// </summary>
public interface IBookCollection
{
    IBookIterator CreateIterator();
}
