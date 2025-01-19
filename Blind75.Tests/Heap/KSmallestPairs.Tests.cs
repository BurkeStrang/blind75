
namespace Blind75.Tests.Heap;

public class KSmallestPairsTests
{
    [Fact]
    public void Example1()
    {
        int[] list1 = [1, 7, 11];
        int[] list2 = [2, 4, 6];
        int k = 3;
        int[][] expected = [[1, 2], [1, 4], [1, 6]];
        int[][] result = FindKPairsWithSum.KSmallestPairs(list1, list2, k);
        result.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Example2()
    {
        int[] list1 = [2, 8, 9];
        int[] list2 = [1, 3, 6];
        int k = 9;
        int[][] expected = [[2, 1], [2, 3], [2, 6], [8, 1], [9, 1], [8, 3], [9, 3], [8, 6], [9, 6]];
        int[][] result = FindKPairsWithSum.KSmallestPairs(list1, list2, k);
        result.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Example3()
    {
        int[] list1 = [1, 2, 3];
        int[] list2 = [1, 2, 3];
        int k = 2;
        int[][] expected = [[1, 1], [1, 2]];
        int[][] result = FindKPairsWithSum.KSmallestPairs(list1, list2, k);
        result.Should().BeEquivalentTo(expected);
    }
}
