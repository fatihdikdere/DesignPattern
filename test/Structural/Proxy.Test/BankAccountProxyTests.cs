namespace Proxy.Test;
public class BankAccountProxyTests
{
    [Fact]
    public void Withdraw_WhenBalanceIsSufficient_ShouldSucceed()
    {
        // Arrange
        var bankAccount = new BankAccount(500);
        var bankAccountProxy = new BankAccountProxy(bankAccount);

        // Act
        var result = bankAccountProxy.Withdraw(100);

        // Assert
        result.Should().BeTrue();
        bankAccountProxy.Balance.Should().Be(400);
    }
    [Fact]
    public void Withdraw_WhenBalanceIsInsufficient_ShouldFail()
    {
        // Arrange
        var bankAccount = new BankAccount(100);
        var bankAccountProxy = new BankAccountProxy(bankAccount);

        // Act
        var result = bankAccountProxy.Withdraw(200);

        // Assert
        result.Should().BeFalse();
        bankAccountProxy.Balance.Should().Be(100);
    }
}
