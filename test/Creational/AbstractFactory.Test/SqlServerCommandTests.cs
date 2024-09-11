namespace AbstractFactory.Test;
public class SqlServerCommandTests
{
    [Fact]
    public void Execute_WhenExecuted_ShouldReturnTrue()
    {
        // Arrange
        var sqlServerCommand = new SqlServerCommand();

        // Act
        var result = sqlServerCommand.Execute();

        // Assert
        result.Should().BeTrue();
    }
}
