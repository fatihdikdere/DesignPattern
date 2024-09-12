namespace Strategy.Test;
public class PaymentContextTests
{
    private readonly Mock<IPaymentStrategy> paymentStrategyMock;
    private PaymentContext paymentContext;

    public PaymentContextTests()
    {
        paymentStrategyMock = new Mock<IPaymentStrategy>();
    }

    [Fact]
    public void ExecutePayment_WhenPaymentStrategyReturnsTrue_ShouldReturnTrue()
    {
        // Arrange
        paymentStrategyMock
            .Setup(s => s.ProcessPayment(It.IsAny<decimal>()))
            .Returns(true);

        paymentContext = new PaymentContext(paymentStrategyMock.Object);
        var amount = 100.00m;

        // Act
        var result = paymentContext.ExecutePayment(amount);

        // Assert
        result.Should().BeTrue();
        paymentStrategyMock.Verify(s => s.ProcessPayment(amount), Times.Once);
    }

    [Fact]
    public void ExecutePayment_WhenPaymentStrategyReturnsFalse_ShouldReturnFalse()
    {
        // Arrange
        paymentStrategyMock
            .Setup(s => s.ProcessPayment(It.IsAny<decimal>()))
            .Returns(false);

        paymentContext = new PaymentContext(paymentStrategyMock.Object);
        var amount = 100.00m;

        // Act
        var result = paymentContext.ExecutePayment(amount);

        // Assert
        result.Should().BeFalse();
        paymentStrategyMock.Verify(s => s.ProcessPayment(amount), Times.Once);
    }
}
