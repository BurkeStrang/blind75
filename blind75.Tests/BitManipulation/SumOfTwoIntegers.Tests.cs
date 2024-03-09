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
}
