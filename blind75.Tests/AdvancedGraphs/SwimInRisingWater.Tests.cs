namespace Blind75.Graphs;

public class SwimInRisingWaterTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] input =
        [
            [0, 2],
            [1, 3]
        ];
        // Act
        int result = new SwimInRisingWater().SwimInWater(input);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] input =
        [
            [0, 1, 2, 3, 4],
            [24, 23, 22, 21, 5],
            [12, 13, 14, 15, 16],
            [11, 17, 18, 19, 20],
            [10, 9, 8, 7, 6]
        ];
        // Act
        int result = new SwimInRisingWater().SwimInWater(input);
        // Assert
        Assert.Equal(16, result);
    }
}
