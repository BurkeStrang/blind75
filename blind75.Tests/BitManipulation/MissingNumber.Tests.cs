public class MissingNumberTests
{
    [Fact]
    public void MissingNumberWhenCalledReturnsMissingNumber()
    {
        // Arrange
        int[] nums = new int[] { 3, 0, 1 };
        // Act
        int result = MissingNumberClass.MissingNumber(nums);
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void MissingNumberWhenCalledReturnsMissingNumber2()
    {
        // Arrange
        int[] nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        // Act
        int result = MissingNumberClass.MissingNumber(nums);
        // Assert
        Assert.Equal(8, result);
    }
}
