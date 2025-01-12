namespace Blind75.Tests.Heap;

public class LastStoneWeightTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        LastStoneWeightClass sut = new();
        int[] stones = [2, 7, 4, 1, 8, 1];
        // Act
        int result = sut.LastStoneWeight(stones);
        // Assert
        Assert.Equal(1, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        LastStoneWeightClass sut = new();
        int[] stones = [1];
        // Act
        int result = sut.LastStoneWeight(stones);
        // Assert
        Assert.Equal(1, result);
    }
}
