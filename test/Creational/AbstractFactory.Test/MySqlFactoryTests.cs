namespace AbstractFactory.Test;
public class MySqlFactoryTests
{
    [Fact]
    public void CreateConnection_WhenCalled_ShouldReturnMySqlConnection()
    {
        // Arrange
        var mySqlFactory = new MySqlFactory();

        // Act
        var connection = mySqlFactory.CreateConnection();

        // Assert
        connection.Should().BeOfType<MySqlConnection>();
    }

    [Fact]
    public void CreateCommand_WhenCalled_ShouldReturnMySqlCommand()
    {
        // Arrange
        var mySqlFactory = new MySqlFactory();

        // Act
        var command = mySqlFactory.CreateCommand();

        // Assert
        command.Should().BeOfType<MySqlCommand>();
    }
}
