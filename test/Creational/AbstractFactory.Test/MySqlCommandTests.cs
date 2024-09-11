namespace AbstractFactory.Test;
public class MySqlCommandTests
{
    [Fact]
    public void Execute_WhenExecuted_ShouldReturnTrue()
    {
        // Arrange
        var mySqlCommand = new MySqlCommand();

        // Act
        var result = mySqlCommand.Execute();

        // Assert
        result.Should().BeTrue();
    }
}
