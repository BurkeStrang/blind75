namespace Blind75.DynamicProgramming;

public class DistinctSubsequecsTests
{
    [Theory]
    [InlineData("rabbbit", "rabbit", 3)]
    [InlineData("babgbag", "bag", 5)]
    public void NumDistinct_ShouldPass(string source, string target, int expected)
    {
        // Arrange
        // Act
        int actual = DistinctSubsequences.NumDistinct(source, target);
        // Assert
        Assert.Equal(expected, actual);
    }
}

