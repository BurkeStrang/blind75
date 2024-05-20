namespace Blind75.DynamicProgramming;

public class PalindromicSubstringsTests
{
    [Fact]
    public void Test1()
    {
        // Given a string s, return the number of palindromic substrings in it.
        // A string is a palindrome when it reads the same backward as forward.
        // A substring is a contiguous sequence of characters within the string.
        // Example 1:
        // Input: s = "abc"
        // Output: 3
        // Explanation: Three palindromic strings: "a", "b", "c".
        string s = "abc";
        int expected = 3;
        int result = PalindromicSubstringsClass.CountSubstrings(s);
        Assert.Equal(expected, result);
    }
}
