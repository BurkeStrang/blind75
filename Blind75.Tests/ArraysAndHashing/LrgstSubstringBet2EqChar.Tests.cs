namespace Blind75.Tests.ArraysAndHashing;

public class LrgstSubstringBet2EqCharTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "aa";
        int expected = 0;
        // Act
        int result = LrgstSubstringBet2EqChar.MaxLengthBetweenEqualCharacters(s);
        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "abca";
        int expected = 2;
        // Act
        int result = LrgstSubstringBet2EqChar.MaxLengthBetweenEqualCharacters(s);
        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "cbzxy";
        int expected = -1;
        // Act
        int result = LrgstSubstringBet2EqChar.MaxLengthBetweenEqualCharacters(s);
        // Assert
        result.Should().Be(expected);
    }
}
