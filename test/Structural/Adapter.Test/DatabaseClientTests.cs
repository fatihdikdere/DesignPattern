namespace Adapter.Test;
public class DatabaseClientTests
{
    [Fact]
    public void TestConnection_WhenConnectionIsSuccessful_ShouldReturnTrue()
    {
        // Arrange
        var databaseAdapterMock = new Mock<IDatabaseAdapter>();
        databaseAdapterMock
            .Setup(adapter => adapter.Connect())
            .Returns(true);

        var databaseClient = new DatabaseClient(databaseAdapterMock.Object);

        // Act
        var result = databaseClient.ConnectionTest();

        // Assert
        result.Should().BeTrue();
        databaseAdapterMock.Verify(adapter => adapter.Connect(), Times.Once);
    }

    [Fact]
    public void TestConnection_WhenConnectionFails_ShouldReturnFalse()
    {
        // Arrange
        var databaseAdapterMock = new Mock<IDatabaseAdapter>();
        databaseAdapterMock
            .Setup(adapter => adapter.Connect())
            .Returns(false);

        var databaseClient = new DatabaseClient(databaseAdapterMock.Object);

        // Act
        var result = databaseClient.ConnectionTest();

        // Assert
        result.Should().BeFalse();
        databaseAdapterMock.Verify(adapter => adapter.Connect(), Times.Once);
    }
}
