using System.Collections;

namespace Blind75.Tests.ArraysAndHashing;

public class UniqueInOrderKataTests
{
    [Fact]
    public void EmptyTest()
    {
        IEnumerable<char> expected = "";
        IEnumerable<char> res = "";
        res.Should().Equal(expected);
    }

    [Fact]
    public void Test1()
    {
        IEnumerable<char> expected = "ABCDAB";
        IEnumerable<char> res = UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB");
        res.Should().Equal(expected);
    }

    [Fact]
    public void Test2()
    {
        IEnumerable<int> expected = [1, 2, 3, 4, 1];
        IEnumerable<int> res = UniqueInOrderKata.UniqueInOrder(
            [1, 2, 2, 2, 3, 3, 4, 4, 1, 1, 1, 1]
        );
        res.Should().Equal(expected);
    }
}
