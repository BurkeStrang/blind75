namespace Blind75.Greedy;

public class HandOfStraightsTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, false)]
    public void IsNStraightHand_ShouldReturnIfHandCanBeDividedIntoNStraightHands(int[] hand, int groupSize, bool expected)
    {
        // Arrange
        // Act
        bool actual = HandOfStraights.IsNStraightHand(hand, groupSize);
        // Assert
        Assert.Equal(expected, actual);
    }
}
