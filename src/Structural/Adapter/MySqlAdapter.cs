namespace Adapter;
/// <summary>
/// Adapter class for my sql
/// </summary>
/// <seealso cref="Adapter.IDatabaseAdapter" />
public class MySqlAdapter : IDatabaseAdapter
{
    public bool Connect()
    {
        Console.WriteLine("Connected to MySQL");

        return true;
    }
}
