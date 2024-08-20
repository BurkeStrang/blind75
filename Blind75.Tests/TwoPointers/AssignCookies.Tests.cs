namespace Blind75.Tests.TwoPointers;

public class AssignCookiesTests
{
    [Fact]
    public void Test1()
    {
        int[] g = [1, 2, 3];
        int[] s = [1, 1];
        int expected = 1;
        int result = AssignCookies.FindContentChildren(g, s);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test2()
    {
        int[] g = [1, 2];
        int[] s = [1, 2, 3];
        int expected = 2;
        int result = AssignCookies.FindContentChildren(g, s);
        Assert.Equal(expected, result);
    }
}
