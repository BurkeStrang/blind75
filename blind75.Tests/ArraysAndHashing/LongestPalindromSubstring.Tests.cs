namespace Blind75.ArraysAndHashing;

public class LongestPalindromeSubstringClass
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "babad";
        string expected = "bab";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindrome(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "cbbd";
        string expected = "bb";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindrome(s);
        // Assert
        Assert.Equal(expected, actual);
    }
}
