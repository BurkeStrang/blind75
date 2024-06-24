namespace Blind75.Tests.TwoPointers;

public class ValidPalindromeTests
{
    [Fact]
    public void ReturnsTrueIfPalindrome()
    {
        // Arrange
        string s = "A";
        Assert.True(ValidPalindrome.IsPalindrome(s));
    }
    [Fact]
    public void ReturnsFalseIfNotPalindrome()
    {
        // Arrange
        string s = "This is not a palindrome";
        Assert.False(ValidPalindrome.IsPalindrome(s));
    }

    [Fact]
    public void ReturnsTrueIfPalindrome2()
    {
        // Arrange
        string s = "race car";
        Assert.True(ValidPalindrome.IsPalindrome(s));
    }
}
