namespace Blind75.Tests.TwoPointers;

public class ReverseStringTests
{
    [Fact]
    public void ExampleTest1()
    {
        // Arrange
        char[] s = ['h', 'e', 'l', 'l', 'o'];
        char[] expected = ['o', 'l', 'l', 'e', 'h'];
        // Act
        ReverseString.Reverse(s);
        // Assert
        s.Should().Equal(expected);
    }

    [Fact]
    public void ExampleTest2()
    {
        // Arrange
        char[] s = ['H', 'a', 'n', 'n', 'a', 'h'];
        char[] expected = ['h', 'a', 'n', 'n', 'a', 'H'];
        // Act
        ReverseString.Reverse(s);
        // Assert
        s.Should().Equal(expected);
    }
}
