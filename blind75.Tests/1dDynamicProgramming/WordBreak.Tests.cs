public class WordBreakTest
{
    public void Test1()
    {
        bool result = WordBreakClass.WordBreak("leetcode", new string[] { "leet", "code" });
        Assert.True(result);
    }
}
