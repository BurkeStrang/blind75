public class WordBreakTest
{
    [Fact]
    [Trait("Category", "Passing")]
    public static void Test1()
    {
        string[] words = { "leet", "code" };
        bool result = WordBreakClass.WordBreak("leetcode", words);
        Assert.True(result);
    }

    [Fact]
    [Trait("Category", "Passing")]
    public static void Test2()
    {
        string[] words = { "apple", "pen" };
        bool result = WordBreakClass.WordBreak("applepenapple", words);
        Assert.True(result);
    }

    [Fact]
    [Trait("Category", "Failing")]
    public static void Test3()
    {
        string[] words = { "cats", "dog", "sand", "and", "cat" };
        bool result = WordBreakClass.WordBreak("catsandog", words);
        Assert.False(result);
    }
}
