namespace AbstractFactory;
/// <summary>
/// Client class
/// </summary>
/// <seealso cref="AbstractFactory.IDatabaseClient" />
internal class DatabaseClient(IDatabaseFactory databaseFactory) : IDatabaseClient
{
    private readonly IDbConnection dbConnection = databaseFactory.CreateConnection();
    private readonly IDbCommand dbCommand = databaseFactory.CreateCommand();
    public void RunQuery()
    {
        if (!dbConnection.Connect())
        {
            return;
        }

        dbCommand.Execute();
    }
}
