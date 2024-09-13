namespace Adapter.Test;
public class MySqlAdapterTests
{
    [Fact]
    public void Connect_WhenConnected_ShouldReturnTrue()
    {
        // Arrange
        var mySqlAdapter = new MySqlAdapter();

        // Act
        var result = mySqlAdapter.Connect();

        // Assert
        result.Should().BeTrue();
    }
}
