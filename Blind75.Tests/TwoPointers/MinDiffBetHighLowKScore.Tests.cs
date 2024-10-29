namespace Blind75.Tests.TwoPointers;

public class MinDiffBetHighLowKScoreTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [90];
        int k = 1;
        int expected = 0;
        // Act
        int actual = MinDiffBetHighLowKScore.MinDifference(nums, k);
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [9, 4, 1, 7];
        int k = 2;
        int expected = 2;
        // Act
        int actual = MinDiffBetHighLowKScore.MinDifference(nums, k);
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [9, 4, 1, 7];
        int k = 3;
        int expected = 5;
        // Act
        int actual = MinDiffBetHighLowKScore.MinDifference(nums, k);
        // Assert
        actual.Should().Be(expected);
    }
}
