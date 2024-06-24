namespace Blind75.LinkedList;

// You are given the head of a singly linked-list. The list can be represented as:

// L0 → L1 → … → Ln - 1 → Ln
// Reorder the list to be on the following form:
// L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
// You may not modify the values in the list's nodes. Only nodes themselves may be changed.

public static class ReorderListClass
{
    // has to modify passed in list
    public static void ReorderList(ListNode? head)
    {
        if (head == null || head.next == null)
            return;

        // find middle
        ListNode? slow = head;
        ListNode? fast = head.next;
        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }

        ListNode? middle = slow?.next;
        slow!.next = null;

        if (middle != null)
        {
            ListNode? secondHead = ReverseLinkedListClass.ReverseList(middle);

            // merge two lists
            ListNode? first = head;
            ListNode? second = secondHead;
            while (second != null)
            {
                ListNode? temp1 = first?.next;
                ListNode? temp2 = second?.next;
                first!.next = second;
                second!.next = temp1;
                first = temp1;
                second = temp2;
            }
        }
        return;
    }
}
