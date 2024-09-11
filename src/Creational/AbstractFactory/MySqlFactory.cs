namespace AbstractFactory;
/// <summary>
/// ConcreteFactory class 1
/// </summary>
/// <seealso cref="AbstractFactory.IDatabaseFactory" />
public class MySqlFactory : IDatabaseFactory
{
    public IDbConnection CreateConnection()
    {
        return new MySqlConnection();
    }
    public IDbCommand CreateCommand()
    {
        return new MySqlCommand();
    }
}
