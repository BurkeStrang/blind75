namespace Blind75.Tests.ArraysAndHashing;

public class LrgstSubstringBet2EqCharTests
{
    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzxy", -1)]
    public void MaxLengthBetweenEqualCharacters_ShouldReturnCorrectValue(string s, int expected)
    {
        // Arrange
        // Act
        int result = LrgstSubstringBet2EqChar.MaxLengthBetweenEqualCharacters(s);
        // Assert
        result.Should().Be(expected);
    }
}
