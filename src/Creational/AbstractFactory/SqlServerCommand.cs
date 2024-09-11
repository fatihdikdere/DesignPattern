namespace AbstractFactory;
/// <summary>
/// ConcreteProduct class B for SQL server
/// </summary>
/// <seealso cref="AbstractFactory.IDbCommand" />
public class SqlServerCommand : IDbCommand
{
    public bool Execute()
    {
        Console.WriteLine("Executing SQL Server command.");

        return true;
    }
}
