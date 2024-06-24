namespace Blind75.Greedy;

public class GasStationTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }, 3)]
    [InlineData(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }, -1)]
    public void CanCompleteCircuit_ShouldReturnTheStartingGasStationIndex(int[] gas, int[] cost, int expected)
    {
        // Arrange
        // Act
        int actual = GasStation.CanCompleteCircuit(gas, cost);
        // Assert
        Assert.Equal(expected, actual);
    }
}
