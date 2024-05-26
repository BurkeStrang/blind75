namespace Blind75.DynamicProgramming;

public class CoinChangeIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int amount = 5;
        int[] coins = [1, 2, 5];
        // Act
        int result = CoinChangeII.Change(amount, coins);

        // Assert
        Assert.Equal(4, result);

    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int amount = 3;
        int[] coins = [2];
        // Act
        int result = CoinChangeII.Change(amount, coins);

        // Assert
        Assert.Equal(0, result);
    }
}
