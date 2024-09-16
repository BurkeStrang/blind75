namespace Blind75.Tests.SlidingWindow;

public class FrequencyOfMostFrequentTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] value = [1, 2, 4];
        int[] nums = value;
        int k = 5;
        int expected = 3;
        // Act
        int actual = FrequencyOfMostFrequent.MaxFrequency(nums, k);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] value = [1, 4, 8, 13];
        int[] nums = value;
        int k = 5;
        int expected = 2;
        // Act
        int actual = FrequencyOfMostFrequent.MaxFrequency(nums, k);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] value = [3, 9, 6];
        int[] nums = value;
        int k = 2;
        int expected = 1;
        // Act
        int actual = FrequencyOfMostFrequent.MaxFrequency(nums, k);
        // Assert
        Assert.Equal(expected, actual);
    }
}
