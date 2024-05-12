namespace Blind75.Backtracking;

public class SubsetsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        SubsetsClass subsetsClass = new();
        // Act
        IList<IList<int>> result = subsetsClass.Subsets(nums);
        ListComparer<int> listComparer = new();
        // Assert
        Assert.True(result.Contains([], listComparer));
        Assert.True(result.Contains([1], listComparer));
        Assert.True(result.Contains([2], listComparer));
        Assert.True(result.Contains([1, 2], listComparer));
        Assert.True(result.Contains([3], listComparer));
        Assert.True(result.Contains([1, 3], listComparer));
        Assert.True(result.Contains([2, 3], listComparer));
        Assert.True(result.Contains([1, 2, 3], listComparer));
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0];
        SubsetsClass subsetsClass = new();
        ListComparer<int> listComparer = new();
        // Act
        IList<IList<int>> result = subsetsClass.Subsets(nums);
        // Assert
        Assert.True(result.Contains([], listComparer));
        Assert.True(result.Contains([0], listComparer));
    }
}
