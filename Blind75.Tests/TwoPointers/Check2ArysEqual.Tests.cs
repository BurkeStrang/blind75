namespace Blind75.Tests.TwoPointers;

public class Check2ArysEqualTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string[] word1 = ["ab", "c"];
        string[] word2 = ["a", "bc"];
        // Act
        bool actual = Check2ArysEqual.ArrayStringsAreEqual(word1, word2);
        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string[] word1 = ["a", "cb"];
        string[] word2 = ["ab", "c"];
        // Act
        bool actual = Check2ArysEqual.ArrayStringsAreEqual(word1, word2);
        // Assert
        Assert.False(actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string[] word1 = ["abc", "d", "defg"];
        string[] word2 = ["abcddefg"];
        // Act
        bool actual = Check2ArysEqual.ArrayStringsAreEqual(word1, word2);
        // Assert
        Assert.True(actual);
    }
}
