namespace Adapter;
/// <summary>
/// Adapter class for sql server
/// </summary>
/// <seealso cref="Adapter.IDatabaseAdapter" />
public class SqlServerAdapter : IDatabaseAdapter
{
    public bool Connect()
    {
        Console.WriteLine("Connected to SQL server");

        return true;
    }
}
