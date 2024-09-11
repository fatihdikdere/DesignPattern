namespace Singleton.Test;
public class SingletonProviderTests
{
    [Fact]
    public void Instance_WhenCalled_ShouldInitializeCorrectly()
    {
        //Arrange
        SampleClass instance;

        // Act
        instance = SingletonProvider<SampleClass>.Instance;

        // Assert
        instance.Id.Should().Be(SampleClassInitialValue.Id);
        instance.FullName.Should().Be(SampleClassInitialValue.FullName);
    }
    [Fact]
    public void Instance_WhenCalled_ShouldReturnSameInstance()
    {
        //Arrange
        SampleClass instance1;
        SampleClass instance2;

        // Act
        instance1 = SingletonProvider<SampleClass>.Instance;
        instance2 = SingletonProvider<SampleClass>.Instance;

        // Assert
        instance1.Should().BeSameAs(instance2);
    }
}
