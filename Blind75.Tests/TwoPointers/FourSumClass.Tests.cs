namespace Blind75.Tests.TwoPointers;

public class FourSumClassTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 0, -1, 0, -2, 2];
        int target = 0;
        List<List<int>> expected =
        [
            [-2, -1, 1, 2],
            [-2, 0, 0, 2],
            [-1, 0, 0, 1],
        ];
        // Act
        IList<IList<int>> actual = FourSumClass.FourSum(nums, target);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [2, 2, 2, 2, 2];
        int target = 8;
        List<List<int>> expected = [[2, 2, 2, 2]];
        // Act
        IList<IList<int>> actual = FourSumClass.FourSum(nums, target);
        // Assert
        Assert.Equal(expected, actual);
    }
}
