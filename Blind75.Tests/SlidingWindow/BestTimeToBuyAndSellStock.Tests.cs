namespace Blind75.Tests.SlidingWindow;

public class BestTimeToBuyAndSellStockTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] prices = [7, 1, 5, 3, 6, 4];
        // Act
        int result = BestTimeToBuyAndSellStock.MaxProfit(prices);
        // Assert
        Assert.Equal(5, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] prices = [7, 6, 4, 3, 1];
        // Act
        int result = BestTimeToBuyAndSellStock.MaxProfit(prices);
        // Assert
        Assert.Equal(0, result);
    }
}
