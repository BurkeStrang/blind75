namespace Blind75.Tests.Graphs;

public class CycleIslandTests
{
    [Fact]
    public void HasCycle_ReturnsTrue_WhenCycleExists()
    {
        char[][] matrix =
        [
                ['a', 'a', 'a', 'a'],
                ['a', 'b', 'b', 'a'],
                ['a', 'b', 'b', 'a'],
                ['a', 'a', 'a', 'a']
        ];

        Assert.True(CycleIsland.HasCycle(matrix));
    }

    [Fact]
    public void HasCycle_ReturnsFalse_WhenNoCycleExists()
    {
        char[][] matrix =
        [
                ['a', 'b', 'c'],
                ['d', 'e', 'f'],
                ['g', 'h', 'i']
        ];

        Assert.False(CycleIsland.HasCycle(matrix));
    }
}
