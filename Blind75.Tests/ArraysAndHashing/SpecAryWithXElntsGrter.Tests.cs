namespace Blind75.Tests.ArraysAndHashing;

public class SpecAryWithXElntsGrterTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [3, 5];
        int expected = 2;
        // Act
        int actual = SpecAryWithXElntsGrter.SpecialArray(nums);
        // Assert
        actual.ShouldBe(expected);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0, 0];
        int expected = -1;
        // Act
        int actual = SpecAryWithXElntsGrter.SpecialArray(nums);
        // Assert
        actual.ShouldBe(expected);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [0, 4, 3, 0, 4];
        int expected = 3;
        // Act
        int actual = SpecAryWithXElntsGrter.SpecialArray(nums);
        // Assert
        actual.ShouldBe(expected);
    }
}
