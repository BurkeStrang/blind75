namespace Blind75.Tests.ArraysAndHashing;

public class FindWordsCharactersTests
{
    [Fact]
    public void Example1()
    {
        string[] words = ["hello", "world", "leetcode"];
        string chars = "welldonehoneyr";
        int expected = 10;
        Assert.Equal(expected, FindWordsCharacters.CountCharacters(words, chars));
    }
    [Fact]
    public void Example2()
    {
        string[] words = ["cat", "bt", "hat", "tree"];
        string chars = "atach";
        int expected = 6;
        Assert.Equal(expected, FindWordsCharacters.CountCharacters(words, chars));
    }
    [Fact]
    public void Example3()
    {
        string[] words = ["hello", "world", "leetcode"];
        string chars = "welldonehoneyr";
        int expected = 10;
        Assert.Equal(expected, FindWordsCharacters.CountCharacters(words, chars));
    }
    [Fact]
    public void Example4()
    {
        string[] words = ["hello", "world", "leetcode"];
        string chars = "welldonehoneyr";
        int expected = 10;
        Assert.Equal(expected, FindWordsCharacters.CountCharacters(words, chars));
    }
    [Fact]
    public void Example5()
    {
        string[] words = ["hello", "world", "leetcode"];
        string chars = "welldonehoneyr";
        int expected = 10;
        Assert.Equal(expected, FindWordsCharacters.CountCharacters(words, chars));
    }
}
