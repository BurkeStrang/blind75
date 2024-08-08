namespace Blind75.Tests.ArraysAndHashing;

public class DesignHashSetTests
{
    [Fact]
    public void Example1()
    {
        MyHashSet hashSet = new();
        hashSet.Add(1);
        hashSet.Add(2);
        Assert.True(hashSet.Contains(1));
        Assert.False(hashSet.Contains(3));
        hashSet.Add(2);
        Assert.True(hashSet.Contains(2));
        hashSet.Remove(2);
        Assert.False(hashSet.Contains(2));
    }
    [Fact]
    public void Example2()
    {
        MyHashSet hashSet = new();
        hashSet.Add(1);
        hashSet.Add(2);
        Assert.True(hashSet.Contains(1));
        Assert.False(hashSet.Contains(3));
        hashSet.Add(2);
        Assert.True(hashSet.Contains(2));
        hashSet.Remove(2);
        Assert.False(hashSet.Contains(2));
        hashSet.Add(1);
        Assert.True(hashSet.Contains(1));
    }
}
