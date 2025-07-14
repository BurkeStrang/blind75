namespace Blind75.Tests.LinkedList;

public class RemoveLinkedListElementTest
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode head = new(1, new(2, new(6, new(3, new(4, new(5, new(6)))))));
        int val = 6;
        ListNode expected = new(1, new(2, new(3, new(4, new(5)))));
        // Act
        ListNode? result = RemoveLinkedListElement.RemoveElements(head, val);
        // Assert
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode? head = null;
        int val = 1;
        ListNode? expected = null;
        // Act
        ListNode? result = RemoveLinkedListElement.RemoveElements(head!, val);
        // Assert
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        ListNode head = new(7, new(7, new(7, new(7))));
        int val = 7;
        ListNode? expected = null;
        // Act
        ListNode? result = RemoveLinkedListElement.RemoveElements(head, val);
        // Assert
        result.ShouldBeEquivalentTo(expected);
    }
}
