namespace Blind75.Tests.ArraysAndHashing;

public class MajorityElementTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [3, 2, 3];
        int expected = 3;
        // Act
        int actual = MajorityElementClass.MajorityElement(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test2()
    {
        // Arrange
        int[] nums = [2, 2, 1, 1, 1, 2, 2];
        int expected = 2;
        // Act
        int actual = MajorityElementClass.MajorityElement(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
