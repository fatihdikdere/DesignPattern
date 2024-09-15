namespace Composite;
/// <summary>
/// Leaf class
/// </summary>
/// <seealso cref="Composite.IFileSystemItem" />
public class File(string name, long size) : IFileSystemItem
{
    private readonly string name = name;
    private readonly long size = size;
    public long GetSize()
    {
        return size;
    }
    public override string ToString()
    {
        return $"File: {name} => Size: {size}";
    }
}
