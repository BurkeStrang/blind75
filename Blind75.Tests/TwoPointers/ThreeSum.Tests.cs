namespace Blind75.Tests.TwoPointers;

public class ThreeSumTests
{
    [Fact]
    public void ReturnsValidThreeSum()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        List<IList<int>> expected =
        [
            [-1, 1, 0],
            [-1, 2, -1]
        ];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }
}
