
public class ContainsDuplicateTests
{
    [Fact]
    public void ReturnsTrueIfDuplicatesExist()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 1 };
        Assert.True(ContainsDuplicateClass.ContainsDuplicate(nums));
    }

    [Fact]
    public void ReturnsFalseIfNoDuplicatesExist()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4 };
        Assert.False(ContainsDuplicateClass.ContainsDuplicate(nums));
    }
}