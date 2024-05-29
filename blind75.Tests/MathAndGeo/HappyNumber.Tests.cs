namespace Blind75.MathAndGeo;

public class HappNumberTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int input = 19;
        // Act and Assert
        Assert.True(HappyNumber.IsHappy(input), $"The input {input} does not return true");
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int input = 2;
        // Act and Assert
        Assert.False(HappyNumber.IsHappy(input), $"The input {input} does not return false");
    }
}
