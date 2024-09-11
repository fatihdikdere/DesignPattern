namespace Builder.Test;
public class MealDirectorTests
{
    private readonly Mock<IMealBuilder> mealBuilderMock;
    private readonly MealDirector mealDirector;
    public MealDirectorTests()
    {
        mealBuilderMock = new Mock<IMealBuilder>();
        mealDirector = new MealDirector(mealBuilderMock.Object);
    }

    [Fact]
    public void Construct_WhenCalled_ShouldCallAllBuildMethods()
    {
        // Arrange

        // Act
        mealDirector.Construct();

        // Assert
        mealBuilderMock.Verify(m => m.BuildMainCourse(), Times.Once);
        mealBuilderMock.Verify(m => m.BuildSideDish(), Times.Once);
        mealBuilderMock.Verify(m => m.BuildDrink(), Times.Once);
        mealBuilderMock.Verify(m => m.BuildDessert(), Times.Once);
    }

    [Fact]
    public void Show_WhenCalledAndMealBuilderNotNull_ShouldCallMealShow()
    {
        // Arrange
        var mealMock = new Mock<Meal>(It.IsAny<MealType>());

        mealBuilderMock
            .Setup(m => m.Meal)
            .Returns(mealMock.Object);

        // Act
        mealDirector.Show();

        // Assert
        mealMock.Verify(m => m.Show(), Times.Once);
    }
}
