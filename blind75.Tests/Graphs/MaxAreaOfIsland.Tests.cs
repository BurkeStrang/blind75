namespace Blind75.Graphs;

public class MaxAreaOfIslandTest
{
    [Fact]
    public void Example1()
    {
        int[][] grid =
        [
            [0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
            [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
            [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0],
            [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]
        ];
        Assert.Equal(6, MaxAreaOfIslandClass.MaxAreaOfIsland(grid));
    }
    [Fact]
    public void Example2()
    {
        int[][] grid =
        [
            [0, 0, 0, 0, 0, 0, 0, 0]
        ];
        Assert.Equal(0, MaxAreaOfIslandClass.MaxAreaOfIsland(grid));
    }

}
