public class insertIntervalsTests
{
    [Fact]
    public void InsertWhenCalledReturnsIntervalsAfterInsertion()
    {
        // Arrange
        int[][] intervals = { new[] { 1, 3 }, new[] { 6, 9 } };
        int[] newInterval = { 2, 5 };
        int[][] expected = { new[] { 1, 5 }, new[] { 6, 9 } };
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }
}
