namespace Blind75.LinkedList;

public class DuplicateNumberTests
{
    [Fact]
    public void FindDuplicate_Example1()
    {
        // Arrange
        int[] nums = [1, 3, 4, 2, 2];
        // Act
        int result = DuplicateNumber.FindDuplicate(nums);
        // Assert
        Assert.Equal(2, result);
    }
    [Fact]
    public void FindDuplicate_Example2()
    {
        // Arrange
        int[] nums = [3, 1, 3, 4, 2];
        // Act
        int result = DuplicateNumber.FindDuplicate(nums);
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void FindDuplicate_Example3()
    {
        // Arrange
        int[] nums = [3, 3, 3, 3, 3];
        // Act
        int result = DuplicateNumber.FindDuplicate(nums);
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void FindDuplicate_ArrayAsHashMapIterative_Example1()
    {
        // Arrange
        int[] nums = [1, 3, 4, 2, 2];
        // Act
        int result = DuplicateNumber.ArrayAsHashMapIterative(nums);
        // Assert
        Assert.Equal(2, result);
    }
    [Fact]
    public void FindDuplicate_ArrayAsHashMapIterative_Example2()
    {
        // Arrange
        int[] nums = [3, 1, 3, 4, 2];
        // Act
        int result = DuplicateNumber.ArrayAsHashMapIterative(nums);
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void FindDuplicate_ArrayAsHashMapIterative_Example3()
    {
        // Arrange
        int[] nums = [3, 3, 3, 3, 3];
        // Act
        int result = DuplicateNumber.ArrayAsHashMapIterative(nums);
        // Assert
        Assert.Equal(3, result);
    }
}
