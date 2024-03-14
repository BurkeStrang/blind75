public class LongestSubstringTests
{
    [Fact]
    public void ABC3()
    {
        string s = "abcabcbb";
        int expected = 3;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void B1()
    {
        string s = "bbbbb";
        int expected = 1;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AU2()
    {
        string s = "au";
        int expected = 2;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void PWWKEW()
    {
        string s = "pwwkew";
        int expected = 3;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DVDF()
    {
        string s = "dvdf";
        int expected = 3;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}
