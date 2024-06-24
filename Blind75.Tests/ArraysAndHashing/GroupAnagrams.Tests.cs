namespace Blind75.Tests.ArraysAndHashing;

public class GroupAnagramsTests
{
    [Fact]
    public void ReturnsGroupedAnagramsThatExist()
    {
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];
        string[][] expected =
        [
            ["eat", "tea", "ate"],
            ["tan", "nat"],
            ["bat"]
        ];
        IList<IList<string>> result = GroupAnagramsClass.GroupAnagrams(strs);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsGroupedAnagramsEmptyString()
    {
        string[] strs = [""];
        string[][] expected = [[""]];
        IList<IList<string>> result = GroupAnagramsClass.GroupAnagrams(strs);
        Assert.Equal(expected, result);
    }
}

