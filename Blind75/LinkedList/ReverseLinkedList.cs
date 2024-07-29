namespace Blind75.LinkedList;

// 0 -> 1 -> 2
// 2 -> 1 -> 0

public static class ReverseLinkedListClass
{
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? dummy = head;

        while (dummy is not null)
        {
            // don't loose next for iterator
            ListNode? iterator = dummy.next;
            // 1. set next equal to previous
            dummy.next = prev;
            // 2. set previous equal to current
            prev = dummy;
            // iterator
            dummy = iterator;
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
