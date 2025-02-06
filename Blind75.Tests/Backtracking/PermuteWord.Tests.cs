namespace Blind75.Tests.Backtracking;
public class PermuteWordTests
{
    [Fact]
    public void Example1()
    {
        string word = "ab";
        IList<string> expected = ["ab", "ba"];
        IList<string> res = PermuteWord.Permute(word);
        Assert.True(new HashSet<string>(res).SetEquals(expected));
    }

    [Fact]
    public void Example2()
    {
        string word = "abc";
        IList<string> expected = ["abc", "acb", "bac", "bca", "cab", "cba"];
        IList<string> res = PermuteWord.Permute(word);
        Assert.True(new HashSet<string>(res).SetEquals(expected));
    }
}

