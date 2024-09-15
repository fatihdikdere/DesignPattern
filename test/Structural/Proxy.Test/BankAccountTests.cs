namespace Proxy.Test;
public class BankAccountTests
{
    [Fact]
    public void Withdraw_WhenBalanceIsSufficient_ShouldSucceedAndUpdateBalance()
    {
        // Arrange
        var bankAccount = new BankAccount(500);

        // Act
        var result = bankAccount.Withdraw(100);

        // Assert
        result.Should().BeTrue();
        bankAccount.Balance.Should().Be(400);
    }
    [Fact]
    public void Withdraw_WhenBalanceIsInsufficient_ShouldFail()
    {
        // Arrange
        var bankAccount = new BankAccount(100);

        // Act
        var result = bankAccount.Withdraw(200);

        // Assert
        result.Should().BeFalse();
        bankAccount.Balance.Should().Be(100);
    }
}
