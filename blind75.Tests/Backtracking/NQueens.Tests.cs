namespace Blind75.Backtracking;

public class NQueensTests
{
    [Fact]
    public void Example1()
    {
        // Given
        int n = 4;
        // When
        IList<IList<string>> result = NQueens.SolveNQueens(n);
        // Then
        Assert.Equal(2, result.Count);
        Assert.Equal(4, result[0].Count);
        Assert.Equal(4, result[1].Count);

        Assert.Equal(".Q..", result[0][0]);
        Assert.Equal("...Q", result[0][1]);
        Assert.Equal("Q...", result[0][2]);
        Assert.Equal("..Q.", result[0][3]);

        Assert.Equal("..Q.", result[1][0]);
        Assert.Equal("Q...", result[1][1]);
        Assert.Equal("...Q", result[1][2]);
        Assert.Equal(".Q..", result[1][3]);
    }
    [Fact]
    public void Example2()
    {
        // Given
        int n = 1;
        // When
        IList<IList<string>> result = NQueens.SolveNQueens(n);
        // Then
        Assert.Equal(1, result.Count);
        Assert.Equal(1, result[0].Count);
        Assert.Equal("Q", result[0][0]);
    }

}


