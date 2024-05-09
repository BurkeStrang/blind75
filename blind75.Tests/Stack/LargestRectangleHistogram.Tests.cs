namespace Blind75.Stack;

public class LargestRectangeHistogramTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] heights = { 2, 1, 5, 6, 2, 3 };
        // Act
        int result = LargestRectangleHistogram.LargestRectangleArea(heights);
        // Assert
        Assert.Equal(10, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] heights = { 2, 4 };
        // Act
        int result = LargestRectangleHistogram.LargestRectangleArea(heights);
        // Assert
        Assert.Equal(4, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] heights = { 2, 1, 2 };
        // Act
        int result = LargestRectangleHistogram.LargestRectangleArea(heights);
        // Assert
        Assert.Equal(3, result);
    }
}
