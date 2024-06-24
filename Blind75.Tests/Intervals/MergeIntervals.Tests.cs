public class MergeIntervalsTests
{
    [Fact]
    public void MergeWhenCalledReturnsNonOverlappingIntervals()
    {
        // Arrange
        int[][] intervals = { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };
        int[][] expected = { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };
        // Act
        int[][] result = MergeIntervals.Merge(intervals);
        // Assert
        Assert.Equal(expected, result);
    }
}
