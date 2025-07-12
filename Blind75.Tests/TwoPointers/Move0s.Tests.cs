namespace Blind75.Tests.TwoPointers;

public class Move0sTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] input =  [ 0, 1, 0, 3, 12 ];
        int[] expected = [1, 3, 12, 0, 0];
        // Act
        Move0s.MoveZeroes(input);
        // Assert
        input.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] input =  [ 0 ];
        int[] expected = [0];
        // Act
        Move0s.MoveZeroes(input);
        // Assert
        input.ShouldBeEquivalentTo(expected);
    }
}
