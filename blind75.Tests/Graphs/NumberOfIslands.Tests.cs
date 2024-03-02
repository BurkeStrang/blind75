public class NumberOfIslands
{
    [Fact]
    public void NumberOfIslandsCorrect()
    {
        // Input: grid = [
        // ["1","1","1","1","0"],
        // ["1","1","0","1","0"],
        // ["1","1","0","0","0"],
        // ["0","0","0","0","0"]
        // ]
        // Output: 1

        char[][] grid = new char[4][];
        grid[0] = new char[] { '1', '1', '1', '1', '0' };
        grid[1] = new char[] { '1', '1', '0', '1', '0' };
        grid[2] = new char[] { '1', '1', '0', '0', '0' };
        grid[3] = new char[] { '0', '0', '0', '0', '0' };

        int exp = 1;
        Assert.Equal(exp, NumerberOfIslandsClass.NumIslands(grid));
    }
}
