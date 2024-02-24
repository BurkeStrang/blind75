public class BestTimeToBuyAndSellStock
{
    [Fact]
    public void BestTimeToBuyAndSellStockValid()
    {
        int[] prices = { 1, -1, 3, 5, 0, 1, 3, 2, 4 };
        int res = 6;
        Assert.Equal(res, BestTimeToBuyAndSell.MaxProfit(prices));
    }
}
