public class ValidParentheses
{
    [Fact]
    public void ReturnsTrueForValidParentheses()
    {
        string s = "()[]{}";
        Assert.True(ValidParenthesesClass.ValidParentheses(s));
    }

    [Fact]
    public void ReturnsFalsForInvalidParentheses()
    {
        string s = ")]{}";
        Assert.False(ValidParenthesesClass.ValidParentheses(s));
    }
}
