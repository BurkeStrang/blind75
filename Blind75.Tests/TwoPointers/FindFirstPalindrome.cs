namespace Blind75.Tests.TwoPointers;

public class FindFirstPalindromeTests
{
    [Fact]
    public void Example1()
    {
        string[] words = ["abc", "car", "ada", "racecar", "cool"];
        string expected = "ada";
        string result = FindFirstPalindrome.FirstPalindrome(words);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example2()
    {
        string[] words = ["notapalindrome", "racecar"];
        string expected = "racecar";
        string result = FindFirstPalindrome.FirstPalindrome(words);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example3()
    {
        string[] words = ["def", "ghi"];
        string expected = "";
        string result = FindFirstPalindrome.FirstPalindrome(words);
        Assert.Equal(expected, result);
    }
}
