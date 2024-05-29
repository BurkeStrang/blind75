namespace Blind75.Greedy;

public class ValidParenthesesStringTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string input = "()";
        // Act
        bool res = ValidParenthesesString.CheckValidString(input);
        // Assert
        Assert.True(res);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string input = "(*)";
        // Act
        bool res = ValidParenthesesString.CheckValidString(input);
        // Assert
        Assert.True(res);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string input = "(*))";
        // Act
        bool res = ValidParenthesesString.CheckValidString(input);
        // Assert
        Assert.True(res, $"The input string '{input}' did not produce a valid result.");
    }
    [Fact]
    public void Example4()
    {
        // Arrange
        string input = "(((*)";
        // Act
        bool res = ValidParenthesesString.CheckValidString(input);
        // Assert
        Assert.False(res, $"The input string '{input}' did not produce a valid result.");
    }


}
