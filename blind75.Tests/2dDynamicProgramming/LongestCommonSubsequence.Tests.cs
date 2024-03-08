public class LongestCommonSubsequenceTests
{
    [Fact]
    public void CorrectLongestCommonSubsequence()
    {
        string text1 = "abcde";
        string text2 = "ace";
        int expected = 3;
        Assert.Equal(
            expected,
            LongestCommonSubsequenceClass.LongestCommonSubsequence(text1, text2)
        );
    }

    [Fact]
    public void CorrectLongestCommonSubsequence2()
    {
        string text1 = "abc";
        string text2 = "def";
        int expected = 0;
        Assert.Equal(
            expected,
            LongestCommonSubsequenceClass.LongestCommonSubsequence(text1, text2)
        );
    }

    [Fact]
    public void CorrectLongestCommonSubsequence3()
    {
        string text1 = "abc";
        string text2 = "abc";
        int expected = 3;
        Assert.Equal(
            expected,
            LongestCommonSubsequenceClass.LongestCommonSubsequence(text1, text2)
        );
    }
}
