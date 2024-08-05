namespace Blind75.Tests.ArraysAndHashing;

public class MonotonicArrayTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 2, 3];
        bool expected = true;
        // Act
        bool actual = MonotonicArray.IsMonotonic(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [6, 5, 4, 4];
        bool expected = true;
        // Act
        bool actual = MonotonicArray.IsMonotonic(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [1, 3, 2];
        bool expected = false;
        // Act
        bool actual = MonotonicArray.IsMonotonic(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
