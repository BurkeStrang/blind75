namespace Blind75.Intervals;

public class MinimumIntervalToIncludeEachQueryTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] intervals = [[1, 3], [2, 3], [3, 7], [6, 6]];
        int[] queries = [2, 3, 1, 7, 6, 8];
        // Act
        int[] res = MinimumIntervalToIncludeEachQuery.MinInterval(intervals, queries);
        // Assert
        int[] exp = [2, 2, 3, 5, 1, -1];
        Assert.Equal(exp, res);
    }
}
