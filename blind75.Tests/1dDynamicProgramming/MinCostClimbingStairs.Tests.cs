namespace Blind75.DynamicProgramming;

public class MinCostClimbingTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] cost = [10, 15, 20];
        int exp = 15;

        // Act
        int res = MinCostClimbing.MinCostClimbingStairs(cost);

        // Assert
        Assert.Equal(exp, res);

    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
        int exp = 6;

        // Act
        int res = MinCostClimbing.MinCostClimbingStairs(cost);

        // Assert
        Assert.Equal(exp, res);

    }

    [Fact]
    public void Example1TopDown()
    {
        // Arrange
        int[] cost = [10, 15, 20];
        int exp = 15;
        // Act
        int res = MinCostClimbing.MinCostClimbingStairsTopDown(cost);
        // Assert
        Assert.Equal(exp, res);
    }

    [Fact]
    public void Example2TopDown()
    {
        // Arrange
        int[] cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
        int exp = 6;
        // Act
        int res = MinCostClimbing.MinCostClimbingStairsTopDown(cost);
        // Assert
        Assert.Equal(exp, res);
    }

}
