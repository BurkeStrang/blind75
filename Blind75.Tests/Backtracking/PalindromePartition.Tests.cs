
namespace Blind75.Tests.Backtracking;

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
        Assert.Contains(["a", "a", "b"], result, listComparer);
        Assert.Contains(["aa", "b"], result, listComparer);
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
        Assert.Contains(["a"], result, listComparer);
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
        Assert.Contains(["a", "a", "b", "b"], result, listComparer);
        Assert.Contains(["aa", "b", "b"], result, listComparer);
        Assert.Contains(["a", "a", "bb"], result, listComparer);
        Assert.Contains(["aa", "bb"], result, listComparer);
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
        Assert.Contains(["a", "b", "c"], result, listComparer);
    }
}
