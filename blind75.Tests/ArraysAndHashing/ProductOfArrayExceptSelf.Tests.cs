public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void ReturnsCorrectArrayValues()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };
        Assert.Equal(expected, ProductOfArrayExceptSelfClass.ProductOfArrayExceptSelf(nums));
    }

    [Fact]
    public void ReturnsCorrectArrayValuesWhenNegative()
    {
        int[] nums = { -1, 1, 0, -3, 3 };
        int[] expected = { 0, 0, 9, 0, 0 };
        Assert.Equal(expected, ProductOfArrayExceptSelfClass.ProductOfArrayExceptSelf(nums));
    }
}
