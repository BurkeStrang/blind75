public class ValidSudokuTests
{
    [Fact]
    public void Test1()
    {
        int[][] grid = new int[9][]
        {
            new int[] { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            new int[] { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            new int[] { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            new int[] { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            new int[] { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            new int[] { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            new int[] { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            new int[] { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            new int[] { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };
        bool result = ValidSudokuClass.ValidSudoku(grid);
        Assert.True(result);
    }
}

