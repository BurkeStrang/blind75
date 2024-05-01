namespace Blind75.ArraysAndHashing;

public class ContainsDuplicateTests
{
    [Fact]
    public void ReturnsTrueIfDuplicatesExist()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1];
        Assert.True(ContainsDuplicateClass.ContainsDuplicate(nums));
    }

    [Fact]
    public void ReturnsFalseIfNoDuplicatesExist()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];
        Assert.False(ContainsDuplicateClass.ContainsDuplicate(nums));
    }

    [Fact]
    public void ReturnsTrueIfDuplicatesExistForLongerArray()
    {
        // Arrange
        int[] nums = [1, 2, 3, 5, 10, 100, -5, -10, -11, -12, 55, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, -5, -10, -11, -12, 55];
        Assert.True(ContainsDuplicateClass.ContainsDuplicate(nums));
    }
}
