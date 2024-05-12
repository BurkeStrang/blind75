
namespace Blind75.Backtracking;

public class PalindromPartitionTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "aab";
        ListComparer<string> listComparer = new();
        // Act
        IList<IList<string>> result = PalindromePartition.Partition(s);
        // Assert
        Assert.True(result.Contains(new List<string> { "a", "a", "b" }, listComparer));
        Assert.True(result.Contains(new List<string> { "aa", "b" }, listComparer));
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "a";
        ListComparer<string> listComparer = new();
        // Act
        IList<IList<string>> result = PalindromePartition.Partition(s);
        // Assert
        Assert.True(result.Contains(new List<string> { "a" }, listComparer));
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "aabb";
        ListComparer<string> listComparer = new();
        // Act
        IList<IList<string>> result = PalindromePartition.Partition(s);
        // Assert
        Assert.True(result.Contains(new List<string> { "a", "a", "b", "b" }, listComparer));
        Assert.True(result.Contains(new List<string> { "aa", "b", "b" }, listComparer));
        Assert.True(result.Contains(new List<string> { "a", "a", "bb" }, listComparer));
        Assert.True(result.Contains(new List<string> { "aa", "bb" }, listComparer));
    }
    [Fact]
    public void Example4()
    {
        // Arrange
        string s = "abc";
        ListComparer<string> listComparer = new();
        // Act
        IList<IList<string>> result = PalindromePartition.Partition(s);
        // Assert
        Assert.True(result.Contains(new List<string> { "a", "b", "c" }, listComparer));
    }
}
