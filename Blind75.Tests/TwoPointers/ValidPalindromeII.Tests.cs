namespace Blind75.Tests.TwoPointers;

public class ValidPalindromeIITests
{
    [Theory]
    [InlineData("aba", true)]
    [InlineData("abca", true)]
    [InlineData("abc", false)]
    public void ValidPalindrome(string s, bool expected)
    {
        // Arrange
        // Act
        bool actual = ValidPalindromeII.ValidPalindrome(s);
        // Assert
        Assert.Equal(expected, actual);
    }
}
