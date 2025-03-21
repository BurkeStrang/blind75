namespace Blind75.Tests.Backtracking;

public class SubsetsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        // Act
        IList<IList<int>> result = SubsetsClass.Subsets(nums);
        ListComparer<int> listComparer = new();
        // Assert
        Assert.Contains([], result, listComparer);
        Assert.Contains([1], result, listComparer);
        Assert.Contains([2], result, listComparer);
        Assert.Contains([1, 2], result, listComparer);
        Assert.Contains([3], result, listComparer);
        Assert.Contains([1, 3], result, listComparer);
        Assert.Contains([2, 3], result, listComparer);
        Assert.Contains([1, 2, 3], result, listComparer);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0];
        ListComparer<int> listComparer = new();
        // Act
        IList<IList<int>> result = SubsetsClass.Subsets(nums);
        // Assert
        Assert.Contains([], result, listComparer);
        Assert.Contains([0], result, listComparer);
    }
}
