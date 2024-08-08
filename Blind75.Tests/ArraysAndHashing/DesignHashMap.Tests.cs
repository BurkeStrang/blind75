namespace Blind75.Tests.ArraysAndHashing;

public class DesignHashMapTests
{
    [Fact]
    public void Example1()
    {
        MyHashMap hashMap = new();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Assert.Equal(1, hashMap.Get(1));
        Assert.Equal(-1, hashMap.Get(3));
        hashMap.Put(2, 1);
        Assert.Equal(1, hashMap.Get(2));
        hashMap.Remove(2);
        Assert.Equal(-1, hashMap.Get(2));
    }
}
