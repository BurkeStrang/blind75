public class TopKFrequentElementsTests
{
    [Fact]
    public void ReturnTopKElements()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        int[] expected = { 1, 2 };
        Assert.Equal(expected, TopKFrequentElementsClass.TopKFrequent(nums, k));
    }
}

