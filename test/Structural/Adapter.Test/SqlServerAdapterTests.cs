namespace Adapter.Test;
public class SqlServerAdapterTests
{
    [Fact]
    public void Connect_WhenConnected_ShouldReturnTrue()
    {
        // Arrange
        var sqlServerAdapter = new SqlServerAdapter();

        // Act
        var result = sqlServerAdapter.Connect();

        // Assert
        result.Should().BeTrue();
    }
}
