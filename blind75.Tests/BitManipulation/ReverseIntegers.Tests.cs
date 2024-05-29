namespace Blind75.BitManipulation;


public class ReverseIntegersTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int x = 123;
        int expected = 321;

        // Act
        int result = ReverseIntegers.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int x = -123;
        int expected = -321;

        // Act
        int result = ReverseIntegers.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int x = 120;
        int expected = 21;

        // Act
        int result = ReverseIntegers.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void OverflowCasePositive()
    {
        // Arrange
        int x = 1534236469;
        int expected = 0;

        // Act
        int result = ReverseIntegers.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void OverflowCaseNegative()
    {
        // Arrange
        int x = -1534236469;
        int expected = 0;

        // Act
        int result = ReverseIntegers.Reverse(x);

        // Assert
        Assert.Equal(expected, result);
    }
}
