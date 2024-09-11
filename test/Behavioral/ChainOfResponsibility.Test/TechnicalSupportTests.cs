namespace ChainOfResponsibility.Test;
public class TechnicalSupportTests
{
    [Fact]
    public void HandleRequest_WhenCalled_ShouldVerify()
    {
        // Arrange
        var technicalSupport = new TechnicalSupport();
        var supportHandlerMock = new Mock<ISupportHandler>();

        supportHandlerMock
            .Setup(handler => handler.HandleRequest())
            .Verifiable();
        technicalSupport.SetNextSupportHandler(supportHandlerMock.Object);

        // Act
        technicalSupport.HandleRequest();

        // Assert
        supportHandlerMock.Verify(handler => handler.HandleRequest(), Times.Once);
    }
}
