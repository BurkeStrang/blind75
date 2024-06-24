public class SearchRotatedSortedArray
{
    [Fact]
    public void ReturnsMinCorrectly()
    {
        int[] nums = { 7, 8, 1, 2, 3, 4, 5, 6 };
        int target = 1;
        int res = 2;
        Assert.Equal(SearchRotatedSortedArrayClass.Search(nums, target), res);
    }
    [Fact]
    public void ReturnsMinCorrectlyInOrder()
    {
        int[] nums = { 0, 1, 2, 3, 4, 5 };
        int target = 4;
        int res = 4;
        Assert.Equal(SearchRotatedSortedArrayClass.Search(nums, target), res);
    }
}
