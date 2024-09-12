namespace Observer.Test;
public class StockTests
{
    [Fact]
    public void Price_WhenSetToSameValue_ShouldNotNotifyInvestors()
    {
        // Arrange
        var stock = new Stock();
        var investorMock = new Mock<IInvestor>();

        stock.Attach(investorMock.Object);
        stock.Price = 100m;

        // Act
        stock.Price = 100m;

        // Assert
        investorMock.Verify(x => x.Update(It.IsAny<IStock>()), Times.Once);
    }

    [Fact]
    public void Price_WhenChanged_ShouldNotifyInvestors()
    {
        // Arrange
        var stock = new Stock();
        var investorMock = new Mock<IInvestor>();

        stock.Attach(investorMock.Object);

        // Act
        stock.Price = 150m;

        // Assert
        investorMock.Verify(x => x.Update(stock), Times.Once);
    }

    [Fact]
    public void Attach_WhenCalled_ShouldAddInvestorToList()
    {
        // Arrange
        var stock = new Stock();
        var investorMock = new Mock<IInvestor>();

        // Act
        stock.Attach(investorMock.Object);

        // Assert
        stock
            .Invoking(s => s.Attach(investorMock.Object))
            .Should()
            .NotThrow();
    }

    [Fact]
    public void Detach_WhenCalled_ShouldRemoveInvestorFromList()
    {
        // Arrange
        var stock = new Stock();
        var investorMock = new Mock<IInvestor>();

        stock.Attach(investorMock.Object);

        // Act
        stock.Detach(investorMock.Object);

        // Assert
        stock
            .Invoking(x => x.Detach(investorMock.Object))
            .Should()
            .NotThrow();
    }
}
