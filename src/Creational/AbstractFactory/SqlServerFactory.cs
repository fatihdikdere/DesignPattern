namespace AbstractFactory;
/// <summary>
/// ConcreteFactory class 1
/// </summary>
/// <seealso cref="AbstractFactory.IDatabaseFactory" />
public class SqlServerFactory : IDatabaseFactory
{
    public IDbConnection CreateConnection()
    {
        return new SqlServerConnection();
    }
    public IDbCommand CreateCommand()
    {
        return new SqlServerCommand();
    }
}
