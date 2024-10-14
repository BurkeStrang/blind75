namespace Blind75.Tests.SlidingWindow;

public class MinimumWindowSubstringTests
{
    [Fact]
    public void ReturnsValidMinimumWindow()
    {
        string s = "ADOBECODEBANC",
            t = "ABC",
            expected = "BANC";
        string result = MinimumWindowSubstringClass.MinWindow(s, t);
        Assert.Equal(expected, result);
    }
}
