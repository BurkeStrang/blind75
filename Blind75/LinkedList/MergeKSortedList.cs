namespace Blind75.LinkedList;

// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

// Merge all the linked-lists into one sorted linked-list and return it.

public static class MergeKSortedListClass
{
    public static ListNode? MergeKLists(ListNode?[] lists)
    {
        for (int i = 1; i < lists.Length; i++)
        {
            lists[0] = MergeTwoListClass.MergeTwoLists(lists[0], lists[i]);
        }
        return lists[0];
    }
}
