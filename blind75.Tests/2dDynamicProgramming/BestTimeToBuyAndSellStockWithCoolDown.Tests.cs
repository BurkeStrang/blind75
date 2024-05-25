namespace Blind75.DynamicProgramming;

public class BestTimeToBuyAndSellStockWithCoolDownTests
{
    [Fact]
    public void Example1()
    {
        // Given
        int[] prices = [1, 2, 3, 0, 2];
        // When
        int result = BestTimeToBuyAndSellStockWithCoolDown.MaxProfit(prices);
        // Then
        Assert.Equal(3, result);
    }
    [Fact]
    public void Example2()
    {
        // Given
        int[] prices = [1];
        // When
        int result = BestTimeToBuyAndSellStockWithCoolDown.MaxProfit(prices);
        // Then
        Assert.Equal(0, result);
    }
}
