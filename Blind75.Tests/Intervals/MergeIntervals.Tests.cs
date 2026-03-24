namespace Blind75.Tests.Intervals;

public class MergeIntervalsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
        int[][] expected = [[1, 6], [8, 10], [15, 18]];
        // Act
        int[][] result = MergeIntervals.Merge(intervals);
        // Assert
        Assert.Equal(expected, result);
    }
}
