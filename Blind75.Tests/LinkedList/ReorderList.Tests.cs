namespace Blind75.Tests.LinkedList;

public class ReorderList
{
    [Fact]
    public void ReorderListCorrect()
    {
        ListNode list = new(0)
        {
            next = new(1)
        };
        list.next.next = new(2)
        {
            next = new(3)
        };
        list.next.next.next.next = new(4)
        {
            next = new(10)
        };
        list.next.next.next.next.next!.next = new ListNode(11);

        ListNode expectedlist = new(0)
        {
            next = new ListNode(11)
        };
        expectedlist.next.next = new ListNode(1)
        {
            next = new ListNode(10)
        };
        expectedlist.next.next.next.next = new ListNode(2)
        {
            next = new ListNode(4)
        };
        expectedlist.next.next.next.next.next!.next = new ListNode(3);

        ReorderListClass.ReorderList(list);

        list.Should().BeEquivalentTo(expectedlist);
    }
}
