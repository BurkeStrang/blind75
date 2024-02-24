public class ValidPalindromeTests
{
    [Fact]
    public void ReturnsTrueIfPalindrome()
    {
        // Arrange
        string s = "A";
        Assert.True(ValidPalindrome.IsPalindrome(s));
    }
}
