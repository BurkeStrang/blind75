namespace Blind75.LinkedList;

/*

Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
k is a positive integer and is less than or equal to the length of the linked list.
If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
You may not alter the values in the list's nodes, only nodes themselves may be changed.

Example 1:
Input: head = [1,2,3,4,5], k = 2
Output: [2,1,4,3,5]

Example 2:
Input: head = [1,2,3,4,5], k = 3
Output: [3,2,1,4,5]
 

Constraints:

The number of nodes in the list is n.
1 <= k <= n <= 5000
0 <= Node.val <= 1000
 

Follow-up: Can you solve the problem in O(1) extra memory space?

*/

public static class ReverseNodesInKGroups
{
    public static ListNode? ReverseKGroup(ListNode? head, int k)
    {
        ListNode? dummy = new(0, head);
        ListNode? groupPrev = dummy;

        while (true)
        {
            ListNode? kth = GetKth(groupPrev, k);
            if (kth == null)
                break;

            ListNode? groupNext = kth.next;

            // reverse group
            ListNode? prev = kth.next;
            ListNode? curr = groupPrev!.next;

            while (curr != groupNext)
            {
                ListNode? temp = curr!.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            ListNode? tmp = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tmp;
        }

        return dummy.next;
    }

    private static ListNode? GetKth(ListNode? curr, int k)
    {
        while (curr != null && k-- > 0)
            curr = curr.next;

        return curr;
    }
}
