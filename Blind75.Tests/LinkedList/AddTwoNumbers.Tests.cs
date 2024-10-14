namespace Blind75.Tests.LinkedList;

public class AddTwoNumbersTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode l1 = new(2) { next = new(4) { next = new(3) } };
        ListNode l2 = new(5) { next = new(6) { next = new(4) } };
        ListNode expected = new(7) { next = new(0) { next = new(8) } };
        // Act
        ListNode? result = AddTwoNumbersClass.AddTwoNumbers(l1, l2);
        // Assert
        Assert.Equivalent(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode l1 = new(0);
        ListNode l2 = new(0);
        ListNode expected = new(0);
        // Act
        ListNode? result = AddTwoNumbersClass.AddTwoNumbers(l1, l2);
        // Assert
        Assert.Equivalent(expected, result);
    }
}
