namespace Blind75.Graphs;

public class WordLadderTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string beginWord = "hit";
        string endWord = "cog";
        string[] wordList = ["hot", "dot", "dog", "lot", "log", "cog"];
        int expected = 5;
        // Act
        int actual = WordLadder.LadderLength(beginWord, endWord, wordList);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string beginWord = "hit";
        string endWord = "cog";
        string[] wordList = ["hot", "dot", "dog", "lot", "log"];
        int expected = 0;
        // Act
        int actual = WordLadder.LadderLength(beginWord, endWord, wordList);
        // Assert
        Assert.Equal(expected, actual);
    }
}
