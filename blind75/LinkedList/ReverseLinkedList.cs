namespace blind75.LinkedList;

public static class ReverseLinkedListClass
{
    public static ListNode? ReverseList(ListNode head)
    {
        ListNode? prev = null,
            curr = head;

        while (curr != null)
        {
            // save the next node
            ListNode? temp = curr.next;
            // set the current node's next to the previous node
            curr.next = prev;
            // move the previous node up
            prev = curr;
            // move the current node up
            curr = temp;
        }
        return prev;
    }

    public static ListNode? ReverseListRecursive(ListNode head)
    {
        if (head is null || head.next is null)
        {
            return head;
        }
        ListNode? p = ReverseListRecursive(head.next);
        head.next.next = head;
        head.next = null;
        return p;
    }
}
