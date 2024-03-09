public class SumOfTwoIntegersTests
{
    [Fact]
    public void GetSumWhenCalledReturnsSum()
    {
        // Arrange
        int a = 1;
        int b = 2;
        // Act
        int result = SumOfTwoIntegers.GetSum(a, b);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void GetSumWhenCalledReturnsSum2()
    {
        // Arrange
        int a = -2;
        int b = 3;
        // Act
        int result = SumOfTwoIntegers.GetSum(a, b);
        // Assert
        Assert.Equal(1, result);
    }
}
