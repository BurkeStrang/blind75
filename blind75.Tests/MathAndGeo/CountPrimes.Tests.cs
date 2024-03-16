public class CountPrimesTests
{
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
}
