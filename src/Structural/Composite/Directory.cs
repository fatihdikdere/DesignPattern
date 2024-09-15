namespace Composite;
/// <summary>
/// Composite
/// </summary>
/// <seealso cref="Composite.IFileSystemItem" />
public class Directory(string name) : IFileSystemItem
{
    private readonly string name = name;
    private readonly List<IFileSystemItem> items = [];
    public IReadOnlyCollection<IFileSystemItem> Items => items;
    public void AddItem(IFileSystemItem item)
    {
        items.Add(item);
    }
    public void RemoveItem(IFileSystemItem item)
    {
        items.Remove(item);
    }
    public long GetSize()
    {
        long totalSize = 0;

        foreach (var item in items)
        {
            totalSize += item.GetSize();
        }

        return totalSize;
    }
    public override string ToString()
    {
        var result = string.Empty;

        result += $"Directory: {name}";
        result += Environment.NewLine;
        result += Environment.NewLine;

        foreach (var item in items)
        {
            result += item.ToString();
            result += Environment.NewLine;
        }

        return result;
    }
}
