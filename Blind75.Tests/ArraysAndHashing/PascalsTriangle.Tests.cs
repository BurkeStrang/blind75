namespace Blind75.Tests.ArraysAndHashing;

public class PascalTriangleTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int numRows = 5;
        IList<IList<int>> expected = [[1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1]];
        // Act
        IList<IList<int>> actual = PascalTriangle.Generate(numRows);
        // Assert
        expected.ShouldBeEquivalentTo(actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int numRows = 1;
        IList<IList<int>> expected = [[1]];
        // Act
        IList<IList<int>> actual = PascalTriangle.Generate(numRows);
        // Assert
        expected.ShouldBeEquivalentTo(actual);
    }
}
