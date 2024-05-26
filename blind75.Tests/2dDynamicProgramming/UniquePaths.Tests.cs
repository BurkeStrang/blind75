namespace Blind75.DynammicProgramming;

public class UniquePathsTest
{
    [Fact]
    public void CorrectUniquePaths()
    {
        int m = 3;
        int n = 2;
        int expected = 3;
        Assert.Equal(expected, UniquePathsClass.UniquePaths(m, n));
    }

    [Fact]
    public void CorrectUniquePaths2()
    {
        int m = 7;
        int n = 3;
        int expected = 28;
        Assert.Equal(expected, UniquePathsClass.UniquePaths(m, n));
    }
}
