namespace blind75.LinkedList;


public static class RemoveNthNodeClass
{
    // Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public static ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        ListNode? dummy = new ListNode(0, head);
        ListNode? left = dummy;
        ListNode? right = head;

        while (n > 0)
        {
            right = right?.next;
            n--;
        }

        while (right != null)
        {
            left = left?.next;
            right = right?.next;
        }

        // delete
        left!.next = left?.next?.next;
        return dummy.next;
    }
}
