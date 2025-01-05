namespace Blind75.LinkedList;

// Given a singly linked list with nn nodes and two positions, left and right,
// the objective is to reverse the nodes of the list from left to right.
// Return the modified list.

// Input: head = [1,2,3,4,5], left = 2, right = 4
// Output: [1,4,3,2,5]



public static class ReverseLinkedListII
{
    public static ListNode? ReverseBetween(ListNode? head, int left, int right)
    {
        // If the list is empty or left position is the same as right, return the original list
        if (head is null || left == right)
            return head;

        // Create a dummy node to handle edge case when left = 1
        ListNode? dummy = new(0, head);
        ListNode? prev = dummy;

        // Move prev to the node just before the left position
        for (int i = 0; i < left - 1; i++)
            prev = prev!.next;

        // Current node is the node at left position
        ListNode? curr = prev!.next;

        // Reverse the portion of the linked list between left and right positions
        for (int i = 0; i < right - left; i++)
        {
            ListNode? nextNode = curr!.next;
            curr!.next = nextNode!.next;
            nextNode!.next = prev.next;
            prev!.next = nextNode;
        }

        // Return the updated head of the linked list
        return dummy.next;
    }
}
