namespace Blind75.Tests.SlidingWindow;

public class ContainsDuplicateIITests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicate_ShouldReturnWhetherThereAreTwoDistinctIndicesWithSameValue(
        int[] nums,
        int k,
        bool expected
    )
    {
        // Arrange
        // Act
        bool actual = ContainsDuplicateII.ContainsNearbyDuplicate(nums, k);
        // Assert
        actual.ShouldBe(expected);
    }
}
