namespace AbstractFactory.Test;
public class SqlServerFactoryTests
{
    [Fact]
    public void CreateConnection_WhenCalled_ShouldReturnMySqlConnection()
    {
        // Arrange
        var sqlServerFactory = new SqlServerFactory();

        // Act
        var connection = sqlServerFactory.CreateConnection();

        // Assert
        connection.Should().BeOfType<SqlServerConnection>();
    }

    [Fact]
    public void CreateCommand_WhenCalled_ShouldReturnMySqlCommand()
    {
        // Arrange
        var sqlServerFactory = new SqlServerFactory();

        // Act
        var command = sqlServerFactory.CreateCommand();

        // Assert
        command.Should().BeOfType<SqlServerCommand>();
    }
}
