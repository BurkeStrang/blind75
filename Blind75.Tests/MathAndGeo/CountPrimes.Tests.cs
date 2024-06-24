namespace Blind75.MathAndGeo;

public class CountPrimesTests
{
    [Fact]
    public void IsPrimeCorrect()
    {
        Assert.True(CountPrimesClass.IsPrime(5));
    }

    [Fact]
    public void CountPrimesCorrect()
    {
        Assert.Equal(4, CountPrimesClass.CountPrimes(10));
    }

    [Fact]
    public void CountPrimesCorrect2()
    {
        Assert.Equal(0, CountPrimesClass.CountPrimes(2));
    }
    [Fact]
    public void CountPrimesCorrect3()
    {
        Assert.Equal(78, CountPrimesClass.CountPrimes(400));
    }
}
