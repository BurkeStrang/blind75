public class ReorderList
{
    [Fact]
    public void ReorderListCorrect()
    {
        ListNode list = new ListNode(0);
        list.next = new ListNode(1);
        list.next.next = new ListNode(2);
        list.next.next.next = new ListNode(3);
        list.next.next.next.next = new ListNode(4);
        list.next.next.next.next.next = new ListNode(10);
        list.next.next.next.next.next.next = new ListNode(11);

        ListNode expectedlist = new ListNode(0);
        expectedlist.next = new ListNode(11);
        expectedlist.next.next = new ListNode(1);
        expectedlist.next.next.next = new ListNode(10);
        expectedlist.next.next.next.next = new ListNode(2);
        expectedlist.next.next.next.next.next = new ListNode(4);
        expectedlist.next.next.next.next.next.next = new ListNode(3);

        ReorderListClass.ReorderList(list);

        Assert.Equivalent(expectedlist, list);
    }
}
