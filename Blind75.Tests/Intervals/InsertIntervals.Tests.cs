namespace Blind75.Tests.Intervals;

public class InsertIntervalsTests
{
    [Fact]
    public void Example1()
    {
        // add to first
        // Arrange
        int[][] intervals = [[1, 3], [6, 9]];
        int[] newInterval = [2, 5];
        int[][] expected = [[1, 5], [6, 9]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // add to last
        // Arrange
        int[][] intervals = [[1, 3], [6, 9]];
        int[] newInterval = [4, 6];
        int[][] expected = [[1, 3], [4, 9]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // no overlap middle
        int[][] intervals = [[1, 3], [6, 9]];
        int[] newInterval = [4, 5];
        int[][] expected = [[1, 3], [4, 5], [6, 9]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example4()
    {
        // no overlap add to first
        // Arrange
        int[][] intervals = [[4, 5], [6, 9]];
        int[] newInterval = [1, 3];
        int[][] expected = [[1, 3], [4, 5], [6, 9]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example5()
    {
        // no overlap add to last
        // Arrange
        int[][] intervals = [[1, 3], [6, 9]];
        int[] newInterval = [10, 12];
        int[][] expected = [[1, 3], [6, 9], [10, 12]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example6()
    {
        // overlap all
        // Arrange
        int[][] intervals = [[1, 3], [6, 9]];
        int[] newInterval = [0, 12];
        int[][] expected = [[0,12]];
        // Act
        int[][] result = InsertIntervals.Insert(intervals, newInterval);
        // Assert
        Assert.Equal(expected, result);
    }

}
