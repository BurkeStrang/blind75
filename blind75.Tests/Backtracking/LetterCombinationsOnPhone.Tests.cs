namespace Blind75.Backtracking;

public class LetterCombinationsOnPhoneTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string digits = "23";
        // Act
        IList<string> result = LetterCombinationsOnPhone.LetterCombinations(digits);
        // Assert
        Assert.True(result.Contains("ad"));
        Assert.True(result.Contains("ae"));
        Assert.True(result.Contains("af"));
        Assert.True(result.Contains("bd"));
        Assert.True(result.Contains("be"));
        Assert.True(result.Contains("bf"));
        Assert.True(result.Contains("cd"));
        Assert.True(result.Contains("ce"));
        Assert.True(result.Contains("cf"));
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string digits = "";
        // Act
        IList<string> result = LetterCombinationsOnPhone.LetterCombinations(digits);
        // Assert
        Assert.Empty(result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string digits = "2";
        // Act
        IList<string> result = LetterCombinationsOnPhone.LetterCombinations(digits);
        // Assert
        Assert.True(result.Contains("a"));
        Assert.True(result.Contains("b"));
        Assert.True(result.Contains("c"));
    }
}
