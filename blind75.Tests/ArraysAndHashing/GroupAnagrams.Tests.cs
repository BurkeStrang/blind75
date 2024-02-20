public class GroupAnagramsTests
{
    [Fact]
    public void ReturnsGroupedAnagramsThatExist()
    {
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        string[][] expected = new string[][]
        {
            new[] { "eat", "tea", "ate" },
            new[] { "tan", "nat" },
            new[] { "bat" }
        };
        var result = GroupAnagramsClass.GroupAnagrams(strs);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsGroupedAnagramsEmptyString()
    {
        string[] strs = { "" };
        string[][] expected = new string[][] { new string[] { "" } };
        var result = GroupAnagramsClass.GroupAnagrams(strs);
        Assert.Equal(expected, result);
    }
}

