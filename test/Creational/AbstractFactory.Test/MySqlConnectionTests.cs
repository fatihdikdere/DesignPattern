namespace AbstractFactory.Test;
public class MySqlConnectionTests
{
    [Fact]
    public void Connect_WhenExecuted_ShouldReturnTrue()
    {
        // Arrange
        var mySqlConnection = new MySqlConnection();

        // Act
        var result = mySqlConnection.Connect();

        // Assert
        result.Should().BeTrue();
    }
}
