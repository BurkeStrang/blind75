namespace Blind75.Tests.ArraysAndHashing;

public class PascalsTriangleIITests
{
    [Fact]
    public void Example1()
    {
        int rowIndex = 3;
        List<int> expected = [1, 3, 3, 1];
        Assert.Equal(expected, PascalsTriangleII.GetRow(rowIndex));
    }
    [Fact]
    public void Example2()
    {
        int rowIndex = 0;
        List<int> expected = [1];
        Assert.Equal(expected, PascalsTriangleII.GetRow(rowIndex));
    }
    [Fact]
    public void Example3()
    {
        int rowIndex = 1;
        List<int> expected = [1, 1];
        Assert.Equal(expected, PascalsTriangleII.GetRow(rowIndex));
    }
}
