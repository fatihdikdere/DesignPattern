namespace AbstractFactory;
/// <summary>
/// AbstractFactory interface
/// </summary>
public interface IDatabaseFactory
{
    IDbConnection CreateConnection();
    IDbCommand CreateCommand();
}
