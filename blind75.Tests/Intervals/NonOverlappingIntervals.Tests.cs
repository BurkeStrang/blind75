public class NonOverlappingIntervalsTests
{
    [Fact]
    public void EraseOverlapIntervalsWhenCalledReturnsNonOverlappingIntervals()
    {
        // Arrange
        int[][] intervals = { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 } };
        int expected = 1;
        // Act
        int result = NonOverlappingIntervals.EraseOverlapIntervals(intervals);
        // Assert
        Assert.Equal(expected, result);
    }
}
