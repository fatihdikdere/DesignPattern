namespace Adapter;
/// <summary>
/// Adaptee class
/// </summary>
public class DatabaseClient(IDatabaseAdapter databaseAdapter)
{
    private readonly IDatabaseAdapter databaseAdapter = databaseAdapter;
    public bool ConnectionTest()
    {
        return databaseAdapter.Connect();
    }
}
