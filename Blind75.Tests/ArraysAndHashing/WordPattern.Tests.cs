namespace Blind75.Tests.ArraysAndHashing;

public class WordPatternTests
{
    [Fact]
    public void Example1()
    {
        string pattern = "abba";
        string s = "dog cat cat dog";
        bool expected = true;
        Assert.Equal(expected, WordPatternClass.WordPattern(pattern, s));
    }

    [Fact]
    public void Example2()
    {
        string pattern = "abba";
        string s = "dog cat cat fish";
        bool expected = false;
        Assert.Equal(expected, WordPatternClass.WordPattern(pattern, s));
    }

    [Fact]
    public void Example3()
    {
        string pattern = "aaaa";
        string s = "dog cat cat dog";
        bool expected = false;
        Assert.Equal(expected, WordPatternClass.WordPattern(pattern, s));
    }

    [Fact]
    public void Example4()
    {
        string pattern = "aaaa";
        string s = "dog dog dog dog";
        bool expected = true;
        Assert.Equal(expected, WordPatternClass.WordPattern(pattern, s));
    }

    [Fact]
    public void WordPattern_TwoDifferentCharsSameWord_ReturnsFalse()
    {
        // Arrange
        string pattern = "ab";
        string s = "dog dog";

        // Act
        bool result = WordPatternClass.WordPattern(pattern, s);

        // Assert
        Assert.False(result);
    }
}
