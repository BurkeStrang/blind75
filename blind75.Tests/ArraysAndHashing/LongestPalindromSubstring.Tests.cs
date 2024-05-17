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
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "a";
        string expected = "a";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindrome(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example4()
    {
        // Arrange
        string s = "ac";
        string expected = "a";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindrome(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example5()
    {
        // Arrange
        string s = "bb";
        string expected = "bb";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindromeExpandAround(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example6()
    {
        // Arrange
        string s = "babad";
        string expected = "aba";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindromeExpandAround(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example7()
    {
        // Arrange
        string s = "cbbd";
        string expected = "bb";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindromeExpandAround(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example8()
    {
        // Arrange
        string s = "a";
        string expected = "a";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindromeExpandAround(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example9()
    {
        // Arrange
        string s = "racecar";
        string expected = "racecar";
        // Act
        string actual = LongestPalindromeSubstring.LongestPalindromeExpandAround(s);
        // Assert
        Assert.Equal(expected, actual);
    }
}
