namespace blind75.SlidingWindow;

public static class BestTimeToBuyAndSell
{
    public static int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            int currPrice = prices[i];
            minPrice = Math.Min(minPrice, currPrice);
            maxProfit = Math.Max(maxProfit, currPrice - minPrice);
        }
        return maxProfit;
    }
}

