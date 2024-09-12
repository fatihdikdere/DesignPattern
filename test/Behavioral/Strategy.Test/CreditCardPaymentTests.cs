namespace Strategy.Test;
public class CreditCardPaymentTests
{
    [Fact]
    public void ProcessPayment_WhenCalled_ShouldReturnTrue()
    {
        // Arrange
        var creditCardPayment = new CreditCardPayment();
        var amount = 100.00m;

        // Act
        var result = creditCardPayment.ProcessPayment(amount);

        // Assert
        result.Should().BeTrue();
    }
}
