namespace Blind75.Tests.ArraysAndHashing;

public class TimeNeededToBuyTicketsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] tickets = [2, 3, 2];
        int k = 2;
        int expected = 6;
        // Act
        int actual = TimeNeededToBuyTickets.BuyTicket(tickets, k);
        // Assert
        actual.Should().Be(expected);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] tickets = [5, 1, 1, 1];
        int k = 0;
        int expected = 8;
        // Act
        int actual = TimeNeededToBuyTickets.BuyTicket(tickets, k);
        // Assert
        actual.Should().Be(expected);
    }
}
