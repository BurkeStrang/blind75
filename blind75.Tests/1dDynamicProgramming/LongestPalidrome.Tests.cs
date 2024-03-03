public class LongestPalidromeTests
{
    [Theory]
    [InlineData("babad", "aba")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "c")]
    public void LongestPalindromeTest(string s, string expected)
    {
        string result = LongestPalindromeClass.LongestPalindrome(s);
        Assert.Equal(expected, result);
    }

}
