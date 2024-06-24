namespace Blind75.Graphs;

public class GraphValidTreeTests
{
    [Fact]
    public void Example1()
    {
        int n = 5;
        int[][] edges = [[0, 1], [0, 2], [0, 3], [1, 4]];
        Assert.True(GraphValidTree.ValidTree(n, edges));
    }
}
