namespace Blind75.Tests.MathAndGeo;

public class PlusOneTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input = [1, 2, 3];
        // Act and Assert
        int[] exp = [1, 2, 4];
        Assert.Equal(exp, PlusOneClass.PlusOne(input));
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input = [4, 3, 2, 1];
        // Act and Assert
        int[] exp = [4, 3, 2, 2];
        Assert.Equal(exp, PlusOneClass.PlusOne(input));
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] input = [9];
        // Act and Assert
        int[] exp = [1, 0];
        Assert.Equal(exp, PlusOneClass.PlusOne(input));
    }
}
