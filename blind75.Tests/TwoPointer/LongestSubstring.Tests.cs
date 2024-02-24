public class LongestSubstringTests
{
    [Fact]
    public void ReturnsValidThreeSum()
    {
        string s = "abcabcbb";
        int expected = 3;
        int result = LongestSubstringClass.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}
