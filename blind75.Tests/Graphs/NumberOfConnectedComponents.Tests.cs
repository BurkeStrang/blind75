namespace Blind75.Graphs;


public class NumberOfConnectedComps
{
    [Fact]
    public void NumberOfConnectedComponents2()
    {
        int input = 5;
        int[][] edges = [[0, 1], [1, 2], [3, 4]];
        int exp = 2;

        Assert.Equal(exp, NumberOfConnectedComponents.CountComponents(input, edges));
    }

    [Fact]
    public void NumberOfConnectedComponents1()
    {
        int input = 3;
        int[][] edges = [[0, 1], [1, 2]];
        int exp = 1;
        Assert.Equal(exp, NumberOfConnectedComponents.CountComponents(input, edges));
    }
}
