namespace Blind75.BinarySearch;

public class TimeBasedKeyValueStoreTests
{
    [Fact]
    public void Example1()
    {
        TimeMap timeMap = new();
        timeMap.Set("foo", "bar", 1);
        Assert.Equal("bar", timeMap.Get("foo", 1));
        Assert.Equal("bar", timeMap.Get("foo", 3));
        timeMap.Set("foo", "bar2", 4);
        Assert.Equal("bar2", timeMap.Get("foo", 4));
        Assert.Equal("bar2", timeMap.Get("foo", 5));
    }

}
