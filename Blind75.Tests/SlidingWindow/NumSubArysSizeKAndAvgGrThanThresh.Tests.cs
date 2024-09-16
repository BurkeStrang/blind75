namespace Blind75.Tests.SlidingWindow;

public class NumSubArysSizeKAndAvgGrThanThreshTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] arr = [2, 2, 2, 2, 5, 5, 5, 8];
        int k = 3;
        int threshold = 4;
        int expected = 3;
        // Act
        int actual = NumSubArysSizeKAndAvgGrThanThresh.NumOfSubarrays(arr, k, threshold);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] arr = [11, 13, 17, 23, 29, 31, 7, 5, 2, 3];
        int k = 3;
        int threshold = 5;
        int expected = 6;
        // Act
        int actual = NumSubArysSizeKAndAvgGrThanThresh.NumOfSubarrays(arr, k, threshold);
        // Assert
        Assert.Equal(expected, actual);
    }
}
