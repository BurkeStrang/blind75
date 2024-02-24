public class ThreeSumTests
{
    [Fact]
    public void ReturnsValidThreeSum()
    {
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };
        var expected = new List<IList<int>>
        {
            new List<int> { -1, 1, 0 },
            new List<int> { -1, 2, -1 }
        };
        var result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }
}
