namespace Blind75.BitManipulation;

public class SingleNumberTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [2, 2, 1];

        // Act
        int result = SingleNumberClass.SingleNumber(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [4, 1, 2, 1, 2];

        // Act
        int result = SingleNumberClass.SingleNumber(nums);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [1];

        // Act
        int result = SingleNumberClass.SingleNumber(nums);

        // Assert
        Assert.Equal(1, result);
    }
}
