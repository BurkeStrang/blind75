public class LongestConsecutiveSequenceTests
{
    [Fact]
    public void ReturnsLongestConsecutiveSequence()
    {
        int[] nums = { 1, 2, 3, 1 };
        int expected = 3;
        Assert.Equal(expected, LongestConsecutiveSequenceClass.LongestConsecutiveSequence(nums));
    }

    [Fact]
    public void ReturnsLongestConsecutiveSequenceForNone()
    {
        int[] nums = { 100, 4, 200, 1, 9, 15 };
        int expected = 1;
        Assert.Equal(expected, LongestConsecutiveSequenceClass.LongestConsecutiveSequence(nums));
    }
}
