namespace Blind75.LinkedList;

// Given a linked list, swap every two adjacent nodes and return its head.
// You must solve the problem without modifying the values in the list's nodes
// (i.e., only nodes themselves may be changed.)
// Example1
// Input: [9,0,8,2]
// Output: [0,9,2,8]

public static class SwapNodesInPairs
{
    public static ListNode? SwapPairs(ListNode? head)
    {
        ListNode? dummy = new(0, head);
        ListNode? prev = dummy;
        ListNode? curr = head;

        while (curr is not null && curr.next is not null)
        {
            // setup first and second nodes
            ListNode? first = curr;
            ListNode? second = curr.next;

            // swap first and second nodes
            first.next = second.next;
            second.next = first;
            prev.next = second;

            // increment prev and curr
            prev = first;
            curr = first.next;
        }

        return dummy.next;
    }
}
