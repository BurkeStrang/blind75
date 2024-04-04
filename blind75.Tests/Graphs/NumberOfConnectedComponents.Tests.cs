// Input: n = 5, edges = [[0,1],[1,2],[3,4]]
// Output: 2

public class NumberOfConnectedComps
{
    [Fact]
    public void NumberOfConnectedComponents2()
    {
        int input = 5;
        int[][] edges = new int[3][];
        edges[0] = [0, 1];
        edges[1] = [1, 2];
        edges[2] = [3, 4];

        int exp = 2;

        Assert.Equal(exp, NumberOfConnectedComponents.CountComponents(input, edges));
    }

    [Fact]
    public void NumberOfConnectedComponents1()
    {
        int input = 3;
        int[][] edges = new int[2][];
        edges[0] = [0, 1];
        edges[1] = [1, 2];

        int exp = 1;
        Assert.Equal(exp, NumberOfConnectedComponents.CountComponents(input, edges));
    }
}
