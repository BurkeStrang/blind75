namespace Blind75.Tests.TwoPointers;

public class RemoveDupsIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 1, 1, 2, 2, 3];
        int expected = 5;
        // Act
        int actual = RemoveDupsII.RemoveDuplicates(nums);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
        int expected = 7;
        // Act
        int actual = RemoveDupsII.RemoveDuplicates(nums);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5, 6];
        int expected = 6;
        // Act
        int actual = RemoveDupsII.RemoveDuplicates(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
