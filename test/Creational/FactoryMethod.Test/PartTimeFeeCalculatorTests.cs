namespace FactoryMethod.Test;
public class PartTimeFeeCalculatorTests
{
    [Theory]
    [InlineData(10, 500)]
    [InlineData(5, 250)]
    [InlineData(0, 0)]
    public void CalculateFee_WhenHoursWorkedIsProvided_ShouldReturnCorrectFee(int hoursWorked, decimal expectedResult)
    {
        // Arrange
        var calculator = new PartTimeFeeCalculator();

        // Act
        var result = calculator.CalculateFee(hoursWorked);

        // Assert
        result.Should().Be(expectedResult);
    }
}
