namespace Blind75.Tests.ArraysAndHashing;

public class UniqueInOrderKataTests
{
    [Fact]
    public void EmptyTest()
    {
        IEnumerable<char> res = "";
        IEnumerable<char> expected = "";
        res.Should().Equal(expected);
    }

    [Fact]
    public void Test1()
    {
        IEnumerable<char> expected = "ABCDAB";
        IEnumerable<char> res = UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB");
        res.Should().Equal(expected);
    }
}
