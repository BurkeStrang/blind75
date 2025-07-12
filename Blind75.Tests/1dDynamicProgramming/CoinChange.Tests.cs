namespace Blind75.DynammicProgramming;

public class CoinChangeTests
{
    [Fact]
    public void Example1()
    {
        int[] coins = [1, 2, 5];
        int amount = 11;
        int expected = 3;
        int result = CoinChangeClass.CoinChange(coins, amount);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        int[] coins = [2];
        int amount = 3;
        int expected = -1;
        int result = CoinChangeClass.CoinChange(coins, amount);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example3()
    {
        int[] coins = [1];
        int amount = 0;
        int expected = 0;
        int result = CoinChangeClass.CoinChange(coins, amount);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example4()
    {
        int[] coins = [1, 2, 5];
        int amount = 100;
        int expected = 20;
        int result = CoinChangeClass.CoinChange(coins, amount);
        Assert.Equal(expected, result);
    }
}

