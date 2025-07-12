namespace Blind75.Tests.LinkedList;

public class ReverseLinkedListIITests
{
    [Fact]
    public void Example1()
    {
        ListNode head = new(9)
        {
            next = new(0)
        };
        head.next.next = new(8)
        {
            next = new(2)
        };

        ListNode expected = new(0)
        {
            next = new(9)
        };
        expected.next.next = new(8)
        {
            next = new(2)
        };

        ListNode? actual = ReverseLinkedListII.ReverseBetween(head, 1, 2);
        actual.ShouldBeEquivalentTo(expected);

    }
}
