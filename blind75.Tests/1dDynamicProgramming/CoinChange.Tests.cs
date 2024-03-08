public class CoinChangeTests
{
    [Fact]
    public void Test1()
    {
        int[] coins = { 1, 2, 5 };
        int amount = 11;
        int expected = 3;
        int result = CoinChangeClass.CoinChange(coins, amount);
        Assert.Equal(expected, result);
    }
}
