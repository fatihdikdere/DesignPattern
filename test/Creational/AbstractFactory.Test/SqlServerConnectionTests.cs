namespace AbstractFactory.Test;
public class SqlServerConnectionTests
{
    [Fact]
    public void Connect_WhenExecuted_ShouldReturnTrue()
    {
        // Arrange
        var sqlServerConnection = new SqlServerConnection();

        // Act
        var result = sqlServerConnection.Connect();

        // Assert
        result.Should().BeTrue();
    }
}
