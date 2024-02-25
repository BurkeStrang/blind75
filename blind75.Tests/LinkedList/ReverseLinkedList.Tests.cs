public class ReverseLinkedList
{
    [Fact]
    public void ReverseLinkedListCorrect()
    {
        ListNode list = new ListNode(0);
        list.next = new ListNode(1);
        list.next.next = new ListNode(2);

        ListNode reversedList = new ListNode(2);
        reversedList.next = new ListNode(1);
        reversedList.next.next = new ListNode(0);

        Assert.Equivalent(reversedList, ReverseLinkedListClass.ReverseList(list));
    }
}
