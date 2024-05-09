namespace Blind75.SlidingWindow;

public class PermutationsInStringTest
{
    [Fact]
    public void ReturnsTrueIfPermutation()
    {
        // Arrange
        string s1 = "ab", s2 = "eidbaooo";
        Assert.True(PermutationsInString.CheckInclusion(s1, s2));
    }
    [Fact]
    public void ReturnsFalseIfNotPermutation()
    {
        // Arrange
        string s1 = "ab", s2 = "eidboaoo";
        Assert.False(PermutationsInString.CheckInclusion(s1, s2));
    }
}
