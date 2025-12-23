
namespace Blind75.Tests.TwoPointers;

public class PartitionLabelTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string input = "ababcbacadefegdehijhklij";
        List<int> expected = [9, 7, 8];
        // Act
        List<int> result = PartitionLabel.PartitionLabels(input);
        // Assert
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string input = "eccbbbbdec";
        List<int> expected = [10];
        // Act
        List<int> result = PartitionLabel.PartitionLabels(input);
        // Assert
        result.ShouldBeEquivalentTo(expected);
    }
}
