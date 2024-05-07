public class TopKFrequentElementsTests
{
    [Fact]
    public void ReturnTopKElements()
    {
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        int[] expected = [1, 2];
        Assert.Equal(expected, TopKFrequentElementsClass.TopKFrequent(nums, k));
    }

    [Fact]
    public void ReturnTopKElementsWhenKIsOne()
    {
        int[] nums = [1];
        int k = 1;
        int[] expected = [1];
        Assert.Equal(expected, TopKFrequentElementsClass.TopKFrequent(nums, k));
    }
    [Fact]
    public void ReturnTopKElementsWhenKIsThree()
    {
        int[] nums = [1, 1, 1, 2, 2, 3, 3, 3, 3];
        int k = 3;
        int[] expected = [3, 1, 2];
        Assert.Equal(expected, TopKFrequentElementsClass.TopKFrequent(nums, k));
    }
}

