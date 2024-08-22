namespace Blind75.Tests.ArraysAndHashing;

public class MinNumSwapToMakeStrBalancedTests
{
    [Fact]
    public void Test1()
    {
        string s = "][][";
        int expected = 1;
        int result = MinNumSwapToMakeStrBalanced.MinSwaps(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        string s = "]]][[[";
        int expected = 2;
        int result = MinNumSwapToMakeStrBalanced.MinSwaps(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        string s = "[]";
        int expected = 0;
        int result = MinNumSwapToMakeStrBalanced.MinSwaps(s);
        Assert.Equal(expected, result);
    }
}
