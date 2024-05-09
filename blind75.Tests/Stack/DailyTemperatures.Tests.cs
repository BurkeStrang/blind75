namespace Blind75.Stack;

public class DailyTemperaturesTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
        // Act
        int[] result = DailyTemperatures.GetInts(temperatures);
        // Assert
        Assert.Equal(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 }, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] temperatures = { 30, 40, 50, 60 };
        // Act
        int[] result = DailyTemperatures.GetInts(temperatures);
        // Assert
        Assert.Equal(new int[] { 1, 1, 1, 0 }, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] temperatures = { 30, 60, 90 };
        // Act
        int[] result = DailyTemperatures.GetInts(temperatures);
        // Assert
        Assert.Equal(new int[] { 1, 1, 0 }, result);
    }
}
