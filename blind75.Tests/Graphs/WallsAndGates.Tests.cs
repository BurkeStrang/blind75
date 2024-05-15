namespace Blind75.Graphs;

public class WallsAndGatesTests
{
    [Fact]
    public void Example1()
    {
        int[][] rooms =
        [
            [int.MaxValue, -1, 0, int.MaxValue],
            [int.MaxValue, int.MaxValue, int.MaxValue, -1],
            [int.MaxValue, -1, int.MaxValue, -1],
            [0, -1, int.MaxValue, int.MaxValue]
        ];
        WallsAndGatesClass.WallsAndGates(rooms);
        int[][] expected =
        [
            [3, -1, 0, 1],
            [2, 2, 1, -1],
            [1, -1, 2, -1],
            [0, -1, 3, 4]
        ];
        Assert.Equal(expected, rooms);
    }
    [Fact]
    public void Example2()
    {
        int[][] rooms =
        [
            [0, -1],
            [int.MaxValue, int.MaxValue]
        ];
        WallsAndGatesClass.WallsAndGates(rooms);
        int[][] expected =
        [
            [0, -1],
            [1, 2]
        ];
        Assert.Equal(expected, rooms);
    }
}
