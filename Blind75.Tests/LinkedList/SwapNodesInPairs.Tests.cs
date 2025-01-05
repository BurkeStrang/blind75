namespace Blind75.Tests.LinkedList;

public class SwapNodesInParsTests
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
        expected.next.next = new(2)
        {
            next = new(8)
        };

        ListNode? actual = SwapNodesInPairs.SwapPairs(head);
        actual.Should().BeEquivalentTo(expected);

    }
}
