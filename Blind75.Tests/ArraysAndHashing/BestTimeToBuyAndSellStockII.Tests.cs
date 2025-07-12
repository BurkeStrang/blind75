namespace Blind75.Tests.ArraysAndHashing;

public class BestTimeToBuyAndSellStockIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] prices = [7, 1, 5, 3, 6, 4];
        int expected = 7;
        // Act
        int result = BestTimeToBuyAndSellStockII.MaxProfit(prices);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] prices = [1, 2, 3, 4, 5];
        int expected = 4;
        // Act
        int result = BestTimeToBuyAndSellStockII.MaxProfit(prices);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] prices = [7, 6, 4, 3, 1];
        int expected = 0;
        // Act
        int result = BestTimeToBuyAndSellStockII.MaxProfit(prices);
        // Assert
        result.ShouldBe(expected);
    }
}
