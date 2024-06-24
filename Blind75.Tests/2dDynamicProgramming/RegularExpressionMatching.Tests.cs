namespace Blind75.DynamicProgramming;

public class RegularExpressionMatchingTests
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    [InlineData("aab", "c*a*b", true)]
    [InlineData("mississippi", "mis*is*p*.", false)]
    public void IsMatch_ShouldPass(string s, string p, bool expected)
    {
        // Arrange
        // Act
        bool actual = RegularExpressionMatching.IsMatch(s, p);
        // Assert
        Assert.Equal(expected, actual);
    }
}
