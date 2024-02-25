namespace blind75.LinkedList;

public static class ReverseLinkedListClass
{
    public static ListNode? ReverseList(ListNode head)
    {
        ListNode? prev = null, curr = head;

        while (curr != null)
        {
            ListNode? temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}
