namespace Blind75.Tests.Intervals;

public class NonOverlappingIntervalsTests
{
    [Fact]
    public void EraseOverlapIntervalsWhenCalledReturnsNonOverlappingIntervals()
    {
        // Arrange
        int[][] intervals = [[1, 2], [2, 3], [3, 4], [1, 3]];
        int expected = 1;
        // Act
        int result = NonOverlappingIntervals.EraseOverlapIntervals(intervals);
        // Assert
        Assert.Equal(expected, result);
    }
}
