namespace Blind75.Tests.LinkedList;

public class CopyListWithRandomPointerTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode head = new(7)
        {
            next = new(13)
        };
        head.next.next = new(11)
        {
            next = new(10)
        };
        head.next.next.next.next = new(1);
        head.next.random = head;
        head.next.next.random = head.next.next.next.next;
        head.next.next.next.random = head.next.next;
        head.next.next.next.next.random = head;
        ListNode expected = head;
        // Act
        ListNode? result = CopyListWithRandomPointer.CopyRandomList(head);
        // Assert
        Assert.True(expected.AreEqual(result));
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode head = new(1)
        {
            next = new(2)
        };
        head.next.random = head.next;
        ListNode expected = head;
        // Act
        ListNode? result = CopyListWithRandomPointer.CopyRandomList(head);
        // Assert
        Assert.True(expected.AreEqual(result));
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        ListNode head = new(3)
        {
            next = new(3)
        };
        head.next.next = new(3);
        head.next.random = head.next.next;
        ListNode expected = head;
        // Act
        ListNode? result = CopyListWithRandomPointer.CopyRandomList(head);
        // Assert
        Assert.True(expected.AreEqual(result));
    }
}
