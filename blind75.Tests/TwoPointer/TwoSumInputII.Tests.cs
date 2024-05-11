namespace Blind75.TwoPointer;

public class TwoSumInputIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] numbers = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [1, 2];
        // Act
        int[] result = TwoSumInputII.TwoSum(numbers, target);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] numbers = [2, 3, 4];
        int target = 6;
        int[] expected = [1, 3];
        // Act
        int[] result = TwoSumInputII.TwoSum(numbers, target);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] numbers = [-1, 0];
        int target = -1;
        int[] expected = [1, 2];
        // Act
        int[] result = TwoSumInputII.TwoSum(numbers, target);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example4()
    {
        int[] numbers = [1, 2, 3, 4, 4, 9, 56, 90];
        int target = 8;
        int[] expected = [4, 5];
        int[] result = TwoSumInputII.TwoSum(numbers, target);
        Assert.Equal(expected, result);
    }
}
