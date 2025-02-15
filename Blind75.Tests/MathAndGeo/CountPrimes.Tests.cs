namespace Blind75.Tests.MathAndGeo;

public class CountPrimesTests
{
    // Count primes without sieve
    [Fact]
    public void Example1()
    {
        Assert.True(CountPrimesClass.IsPrime(5));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, CountPrimesClass.CountPrimes(10));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(0, CountPrimesClass.CountPrimes(2));
    }
    [Fact]
    public void Example4()
    {
        Assert.Equal(78, CountPrimesClass.CountPrimes(400));
    }

    // Sieve
    [Fact]
    public void CountPrimesSieve_Example1()
    {
        Assert.Equal(4, CountPrimesClass.CountPrimesSieve(10));
    }
}
