namespace Blind75.Tests.ArraysAndHashing;

public class UniqLgth3PalinSubseqTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "aabca";
        int expected = 3;
        // Act
        int result = UniqLgth3PalinSubseq.CountPalindromicSubsequence(s);
        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "adc";
        int expected = 0;
        // Act
        int result = UniqLgth3PalinSubseq.CountPalindromicSubsequence(s);
        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "bbcbaba";
        int expected = 4;
        // Act
        int result = UniqLgth3PalinSubseq.CountPalindromicSubsequence(s);
        // Assert
        result.Should().Be(expected);
    }
}
