namespace Blind75.LinkedList;

// 0 -> 1 -> 2
// prev
// 0 -> null
// 1 -> 0 -> null
// 2 -> 1 -> 0 -> null

public static class ReverseLinkedListClass
{
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? curr = head;

        while (curr is not null)
        {
            // don't loose next for iterator
            ListNode? next = curr.next;
            // set next equal to previous
            curr.next = prev;
            // set previous equal to current
            prev = curr;
            // iterator
            curr = next;
        }

        return prev;
    }

    public static ListNode? ReverseListRecursive(ListNode? head)
    {
        if (head is null || head.next is null)
            return head;

        ListNode? p = ReverseListRecursive(head.next);
        head.next.next = head;
        head.next = null;
        return p;
    }
}
