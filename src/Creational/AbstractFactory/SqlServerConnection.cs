namespace AbstractFactory;
/// <summary>
/// ConcreteProduct class A for SQL server
/// </summary>
/// <seealso cref="AbstractFactory.IDbConnection" />
public class SqlServerConnection : IDbConnection
{
    public bool Connect()
    {
        Console.WriteLine("Connecting to SQL Server database.");

        return true;
    }
}
