namespace AbstractFactory;
/// <summary>
/// ConcreteProduct class A for MySQL
/// </summary>
/// <seealso cref="AbstractFactory.IDbConnection" />
public class MySqlConnection : IDbConnection
{
    public bool Connect()
    {
        Console.WriteLine("Connecting to MySQL database.");

        return true;
    }
}
