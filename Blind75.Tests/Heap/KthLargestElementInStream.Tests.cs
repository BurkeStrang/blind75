namespace Blind75.Heap;

public class KthLargestElementInStreamTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        KthLargest sut = new(3, [4, 5, 8, 2]);
        // Act
        int result1 = sut.Add(3);
        int result2 = sut.Add(5);
        int result3 = sut.Add(10);
        int result4 = sut.Add(9);
        int result5 = sut.Add(4);
        // Assert
        Assert.Equal(4, result1);
        Assert.Equal(5, result2);
        Assert.Equal(5, result3);
        Assert.Equal(8, result4);
        Assert.Equal(8, result5);
    }
}
