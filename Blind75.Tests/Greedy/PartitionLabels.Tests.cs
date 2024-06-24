namespace Blind75.Greedy;

public class PartitionLabelsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string input = "ababcbacadefegdehijhklij";
        // Act
        IList<int> res = PartitionLabelsClass.PartitionLabels(input);
        // Assert
        IList<int> exp = [9, 7, 8];
        Assert.Equal(exp, res);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string input = "eccbbbbdec";
        // Act
        IList<int> res = PartitionLabelsClass.PartitionLabels(input);
        // Assert
        IList<int> exp = [10];
        Assert.Equal(exp, res);
    }
}
