public class RemoveNthNode
{
    [Fact]
    public void RemoveNthNodeCorrect()
    {
        ListNode originalList = new ListNode(0);
        originalList.next = new ListNode(1);
        originalList.next.next = new ListNode(2);
        originalList.next.next.next = new ListNode(3);
        originalList.next.next.next.next = new ListNode(4);
        originalList.next.next.next.next.next = new ListNode(10);
        originalList.next.next.next.next.next!.next = new ListNode(11);


        ListNode expectedList = new ListNode(0);
        expectedList.next = new ListNode(1);
        expectedList.next.next = new ListNode(2);
        expectedList.next.next.next = new ListNode(3);
        expectedList.next.next.next.next = new ListNode(4);
        expectedList.next.next.next.next.next = new ListNode(11);

        Assert.Equivalent(expectedList, RemoveNthNodeClass.RemoveNthFromEnd(originalList, 2));
    }
}
