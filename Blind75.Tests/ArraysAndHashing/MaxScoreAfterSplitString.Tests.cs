namespace Blind75.Tests.ArraysAndHashing;

public class MaxScoreAfterSplitStringTests
{
    [Theory]
    [InlineData("011101", 5)]
    [InlineData("00111", 5)]
    [InlineData("1111", 3)]
    public void MaxScore_ShouldReturnMaxScore(string s, int expected)
    {
        // Arrange
        // Act
        int result = MaxScoreAfterSplitString.MaxScore(s);
        // Assert
        result.Should().Be(expected);
    }
}
