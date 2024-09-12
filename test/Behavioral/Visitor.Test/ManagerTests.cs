namespace Visitor.Test;
public class ManagerTests
{
    [Fact]
    public void Accept_WhenCalled_ShouldCallVisitManager()
    {
        // Arrange
        var manager = new Manager();
        var visitorMock = new Mock<IReviewVisitor>();

        // Act
        manager.Accept(visitorMock.Object);

        // Assert
        visitorMock.Verify(v => v.Visit(manager), Times.Once);
    }
}
