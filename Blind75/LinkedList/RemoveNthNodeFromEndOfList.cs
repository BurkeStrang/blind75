namespace Blind75.LinkedList;

// Given the head of a linked list, remove the nth node from the end of the list and return its head.

public static class RemoveNthNodeClass
{
    public static ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {

        ListNode? res = new(0, head);
        ListNode? slow = res;
        ListNode? fast = res;

        while (n > 0)
        {
            n--;
            fast = fast!.next;
        }

        while (fast != null && fast.next != null)
        {
            fast = fast!.next;
            slow = slow!.next;
        }

        slow!.next = slow.next!.next;

        return res.next;
    }
}
