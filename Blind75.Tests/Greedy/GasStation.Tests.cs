namespace Blind75.Tests.Greedy;

public class GasStationTests
{
    [Fact]
    public void Example1()
    {
        int[] gas = [1, 2, 3, 4, 5];
        int[] cost = [3, 4, 5, 1, 2];
        int expected = 3;
        int actual = GasStation.CanCompleteCircuit(gas, cost);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        int[] gas = [2, 3, 4];
        int[] cost = [3, 4, 3];
        int expected = -1;
        int actual = GasStation.CanCompleteCircuit(gas, cost);
        Assert.Equal(expected, actual);
    }
}
