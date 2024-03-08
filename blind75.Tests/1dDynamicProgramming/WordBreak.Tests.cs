public class WordBreakTest
{
    [Fact]
    public static void Test1()
    {
        string[] words = { "leet", "code" };
        bool result = WordBreakClass.WordBreak("leetcode", words);
        Assert.True(result);
    }

    [Fact]
    public static void Test2()
    {
        string[] words = { "apple", "pen" };
        bool result = WordBreakClass.WordBreak("applepenapple", words);
        Assert.True(result);
    }
}
