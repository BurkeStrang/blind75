namespace Blind75.LinkedList;

// You are given the heads of two sorted linked lists list1 and list2.
// Merge the two lists into one sorted list.
// The list should be made by splicing together the nodes of the first two lists.
// Return the head of the merged linked list.

public static class MergeTwoListClass
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode res = new();
        ListNode iterator = res;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                iterator.next = list1;
                list1 = list1.next;
            }
            else
            {
                iterator.next = list2;
                list2 = list2.next;
            }
            iterator = iterator.next;
        }

        if (list1 is not null)
            iterator.next = list1;
        if (list2 is not null)
            iterator.next = list2;
        return res.next;
    }
}
