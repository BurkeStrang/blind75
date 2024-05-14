namespace Blind75.Graphs;

public class GraphValid
{
    [Fact]
    public void GraphValidCorrect()
    {
        int n = 5;
        int[][] edges = [[0, 1], [0, 2], [0, 3], [1, 4]];
        Assert.True(GraphValidTree.ValidTree(n, edges));
    }
}
