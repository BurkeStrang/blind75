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

    [Fact]
    public void ReturnsEmptyListForNoThreeSum()
    {
        int[] nums = [1, 2, 3, 4, 5];
        List<IList<int>> expected = [];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsEmptyListForEmptyArray()
    {
        int[] nums = [];
        List<IList<int>> expected = [];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsEmptyListForSingleElementArray()
    {
        int[] nums = [1];
        List<IList<int>> expected = [];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsExpectedThreeSumForAllZeroes()
    {
        int[] nums = [0, 0, 0, 0];
        List<IList<int>> expected =
        [
            [0, 0, 0]
        ];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsExpectedThreeSumForLargeInput()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4];
        List<IList<int>> expected =
        [
            [-4, 0, 4],
            [-4, 1, 3],
            [-3, -1, 4],
            [-3, 0, 3],
            [-3, 1, 2],
            [-2, -1, 3],
            [-2, 0, 2],
            [-1, -1, 2],
            [-1, 0, 1]
        ];
        IList<IList<int>> result = ThreeSumClass.ThreeSum(nums);
        // fluent assertion that collections are equivalent in any order
        result.Should().BeEquivalentTo(expected);
    }
}
