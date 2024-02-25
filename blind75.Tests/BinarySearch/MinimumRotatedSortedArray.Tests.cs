public class MinimumRotatedSortedArray
{
    [Fact]
    public void ReturnsMinCorrectly()
    {
        int[] nums = { 7, 8, 1, 2, 3, 4, 5, 6 };
        int res = 1;
        Assert.Equal(MinimumRotatedSortedArrayClass.FindMin(nums), res);
    }
    [Fact]
    public void ReturnsMinCorrectlyInOrder()
    {
        int[] nums = { 0, 1, 2, 3, 4, 5 };
        int res = 0;
        Assert.Equal(MinimumRotatedSortedArrayClass.FindMin(nums), res);
    }
}
