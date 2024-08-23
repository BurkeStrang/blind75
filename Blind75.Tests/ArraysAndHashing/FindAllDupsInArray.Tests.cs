using System.Collections;

namespace Blind75.Tests.ArraysAndHashing;

public class FindAllDupsInArrayTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
        IList<int> expected = [2, 3];
        // Act
        IList<int> result = FindAllDupsInArray.FindDuplicates(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [1, 1, 2];
        IList<int> expected = [1];
        // Act
        IList<int> result = FindAllDupsInArray.FindDuplicates(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [1];
        IList<int> expected = [];
        // Act
        IList<int> result = FindAllDupsInArray.FindDuplicates(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
