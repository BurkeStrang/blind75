namespace Blind75.Tests.ArraysAndHashing;

public class FindPivotIndexTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [1, 7, 3, 6, 5, 6];
        int expected = 3;
        // Act
        int actual = FindPivotIndex.PivotIndex(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test2()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        int expected = -1;
        // Act
        int actual = FindPivotIndex.PivotIndex(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
