public class ValidParentheses
{
    [Fact]
    public void ReturnsTrueForValidParentheses()
    {
        string s = "()[]{}";
        Assert.Equal(ValidParenthesesClass.ValidParentheses(s), true);
    }

    [Fact]
    public void ReturnsFalsForInvalidParentheses()
    {
        string s = ")]{}";
        Assert.Equal(ValidParenthesesClass.ValidParentheses(s), false);
    }
}
