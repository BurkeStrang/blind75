namespace Blind75.Tests.Backtracking;

public class SubsetsIITests
{
    [Fact]
    public void Example1()
    {
        // Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
        // The solution set must not contain duplicate subsets. Return the solution in any order.
        // Input: nums = [1,2,2]
        // Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
        int[] nums = [1, 2, 2];
        ListComparer<int> listComparer = new();
        IList<IList<int>> expected =
        [
            [],
            [1],
            [1, 2],
            [1, 2, 2],
            [2],
            [2, 2]
        ];
        IList<IList<int>> actual = SubsetsII.Subsets(nums);
        Assert.True(expected.SequenceEqual(actual, listComparer));
    }

    [Fact]
    public void Example2()
    {
        // Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
        // The solution set must not contain duplicate subsets. Return the solution in any order.
        // Input: nums = [0]
        // Output: [[],[0]]
        int[] nums = [0];
        ListComparer<int> listComparer = new();
        IList<IList<int>> expected =
        [
            [],
            [0]
        ];
        IList<IList<int>> actual = SubsetsII.Subsets(nums);
        Assert.True(expected.SequenceEqual(actual, listComparer));
    }
}
