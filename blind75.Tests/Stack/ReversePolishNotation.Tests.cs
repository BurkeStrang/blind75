namespace Blind75.Stack;

public class ReversePolishNotationTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string[] tokens = ["2", "1", "+", "3", "*"];
        // Act
        int result = ReversePolishNotation.EvalRPN(tokens);
        // Assert
        Assert.Equal(9, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string[] tokens = ["4", "13", "5", "/", "+"];
        // Act
        int result = ReversePolishNotation.EvalRPN(tokens);
        // Assert
        Assert.Equal(6, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string[] tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"];
        // Act
        int result = ReversePolishNotation.EvalRPN(tokens);
        // Assert
        Assert.Equal(22, result);
    }
}
