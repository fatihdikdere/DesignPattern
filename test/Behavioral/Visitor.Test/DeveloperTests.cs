namespace Visitor.Test;
public class DeveloperTests
{
    [Fact]
    public void Accept_WhenCalled_ShouldCallVisitDeveloper()
    {
        // Arrange
        var developer = new Developer();
        var visitorMock = new Mock<IReviewVisitor>();

        // Act
        developer.Accept(visitorMock.Object);

        // Assert
        visitorMock.Verify(v => v.Visit(developer), Times.Once);
    }
}
