namespace Blind75.Tests.ArraysAndHashing;

public class RemoveElement
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [3, 2, 2, 3];
        int val = 3;
        int expected = 2;
        // Act
        int actual = RemoveElementClass.RemoveElement(nums, val);
        // Assert
        expected.ShouldBe(actual);
        nums[..actual].ShouldBeEquivalentTo(new int[] { 2, 2 });
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        int val = 2;
        int expected = 5;
        // Act
        int actual = RemoveElementClass.RemoveElement(nums, val);
        // Assert
        expected.ShouldBe(actual);
        nums[..actual].ShouldBeEquivalentTo(new int[] { 0, 1, 3, 0, 4 });
    }
}
