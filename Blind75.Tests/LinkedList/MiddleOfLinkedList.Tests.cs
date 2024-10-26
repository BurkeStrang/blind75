namespace Blind75.Tests.LinkedList;

public class MiddleOfLinkedListTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode head = new(1, new(2, new(3, new(4, new(5)))));
        ListNode expected = new(3, new(4, new(5)));
        // Act
        ListNode? result = MiddleOfLinkedList.MiddleNode(head);
        // Assert
        expected.Should().BeEquivalentTo(result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode head = new(1, new(2, new(3, new(4, new(5, new(6))))));
        ListNode expected = new(4, new(5, new(6)));
        // Act
        ListNode? result = MiddleOfLinkedList.MiddleNode(head);
        // Assert
        expected.Should().BeEquivalentTo(result);
    }
}
