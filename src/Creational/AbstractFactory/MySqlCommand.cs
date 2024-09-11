namespace AbstractFactory;
/// <summary>
/// ConcreteProduct class B for MySQL
/// </summary>
/// <seealso cref="AbstractFactory.IDbCommand" />
public class MySqlCommand : IDbCommand
{
    public bool Execute()
    {
        Console.WriteLine("Executing MySQL command.");

        return true;
    }
}