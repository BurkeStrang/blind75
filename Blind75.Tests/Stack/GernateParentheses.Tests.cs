namespace Blind75.Tests.Stack;

public class GenerateParenthesesTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int n = 3;
        string[] expected = ["((()))", "(()())", "(())()", "()(())", "()()()"];
        // Act
        IList<string> result = GenerateParentheses.GenerateParenthesis(n);
        // Assert
        Assert.Equal(expected, result);
    }


    [Fact]
    public void Example2()
    {
        // Arrange
        int n = 1;
        string[] expected = ["()"];
        // Act
        IList<string> result = GenerateParentheses.GenerateParenthesis(n);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int n = 2;
        string[] expected = ["(())", "()()"];
        // Act
        IList<string> result = GenerateParentheses.GenerateParenthesis(n);
        // Assert
        Assert.Equal(expected, result);
    }
}

