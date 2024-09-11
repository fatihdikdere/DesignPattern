namespace FactoryMethod.Test;
public class FullTimeFeeCalculatorTests
{
    [Theory]
    [InlineData(10, 1000)]
    [InlineData(5, 500)]
    [InlineData(0, 0)]
    public void CalculateFee_WhenHoursWorkedIsProvided_ShouldReturnCorrectFee(int hoursWorked, decimal expectedResult)
    {
        // Arrange
        var calculator = new FullTimeFeeCalculator();

        // Act
        var result = calculator.CalculateFee(hoursWorked);

        // Assert
        result.Should().Be(expectedResult);
    }
}
