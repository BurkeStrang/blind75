namespace Blind75.Tests.Heap;

public class MaximumCapitalTest
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int c = 0;
        int k = 1;
        int[] capitals = [1, 1, 2];
        int[] profits = [1, 2, 3];
        // Act
        int result = StartupCapital.MaximumCapital(c, k, capitals, profits);
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int c = 1;
        int k = 2;
        int[] capitals = [1, 2, 2, 3];
        int[] profits = [2, 4, 6, 8];
        // Act
        int result = StartupCapital.MaximumCapital(c, k, capitals, profits);
        // Assert
        Assert.Equal(11, result);
    }
}
