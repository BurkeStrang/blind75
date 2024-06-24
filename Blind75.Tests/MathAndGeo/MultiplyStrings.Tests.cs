namespace Blind75.MathAndGeo;

public class MultiplyStringsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string num1 = "2";
        string num2 = "3";
        // Act and Assert
        string exp = "6";
        Assert.Equal(exp, MultiplyStrings.Multiply(num1, num2));
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string num1 = "123";
        string num2 = "456";
        // Act and Assert
        string exp = "56088";
        Assert.Equal(exp, MultiplyStrings.Multiply(num1, num2));
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string num1 = "50000000000000";
        string num2 = "30000000000000";
        // Act and Assert
        string exp = "1500000000000000000000000000";
        Assert.Equal(exp, MultiplyStrings.Multiply(num1, num2));
    }
    [Fact]
    public void Example4()
    {
        // Arrange
        string num1 = "11";
        string num2 = "11";
        // Act and Assert
        string exp = "121";
        Assert.Equal(exp, MultiplyStrings.Multiply(num1, num2));
    }
}
