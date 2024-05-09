namespace Blind75.TwoPointer;

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
}
