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
        ListNode? dummy = head;

        while (dummy is not null)
        {
            // don't loose next for iterator
            // 1
            ListNode? iterator = dummy.next;
            // set next equal to previous
            // null
            dummy.next = prev;
            // set previous equal to current
            // 1 -> null
            prev = dummy;
            // iterator
            // 
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
