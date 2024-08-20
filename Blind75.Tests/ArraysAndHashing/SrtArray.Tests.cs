namespace Blind75.Tests.ArraysAndHashing
{
    using Blind75.ArraysAndHashing;
    using FluentAssertions;
    using Xunit;

    public class SrtArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            int[] nums = [5, 2, 3, 1];
            int[] expected = [1, 2, 3, 5];
            // Act
            int[] result = SrtArray.SortArray(nums);
            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            int[] nums = [5, 1, 1, 2, 0, 0];
            int[] expected = [0, 0, 1, 1, 2, 5];
            // Act
            int[] result = SrtArray.SortArray(nums);
            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
