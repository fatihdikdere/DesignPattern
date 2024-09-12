namespace Strategy.Test;
public class BitcoinPaymentTests
{
    [Fact]
    public void ProcessPayment_WhenCalled_ShouldReturnTrue()
    {
        // Arrange
        var bitcoinPayment = new BitcoinPayment();
        var amount = 100.00m;

        // Act
        var result = bitcoinPayment.ProcessPayment(amount);

        // Assert
        result.Should().BeTrue();
    }
}
