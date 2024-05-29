namespace Blind75.MathAndGeo;

public class PowTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        double x = 2.00000;
        long n = 10;
        // Act and Assert
        double exp = 1024.00000;
        Assert.Equal(exp, Pow.MyPow(x, n));
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        double x = 2.10000;
        long n = 3;
        // Act and Assert
        double exp = 9.261000000000001;
        Assert.Equal(exp, Pow.MyPow(x, n));
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        double x = 2.00000;
        long n = -2;
        // Act and Assert
        double exp = 0.25000;
        Assert.Equal(exp, Pow.MyPow(x, n));
    }
}
