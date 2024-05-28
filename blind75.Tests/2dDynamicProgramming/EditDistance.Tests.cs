namespace Blind75.DynamicProgramming;

public class EditDistanceTests
{
    [Theory]
    [InlineData("horse", "ros", 3)]
    [InlineData("intention", "execution", 5)]
    public void MinDistance_ShouldPass(string word1, string word2, int expected)
    {
        // Arrange
        // Act
        int actual = EditDistance.MinDistance(word1, word2);
        // Assert
        Assert.Equal(expected, actual);
    }
}
