
// Input: n = 5, edges = [[0,1],[1,2],[3,4]]
// Output: 2

public class NumberOfConnectedComps
{
    [Fact]
    public void NumberOfConnectedComponentsCorrect()
    {
        int input = 5;
        int[][] edges = new int[3][];
        edges[0] = new int[] { 0, 1 };
        edges[1] = new int[] { 1, 2 };
        edges[2] = new int[] { 3, 4 };

        int exp = 2;

        Assert.Equal(exp, NumberOfConnectedComponents.CountComponents(input, edges));
    }
}
