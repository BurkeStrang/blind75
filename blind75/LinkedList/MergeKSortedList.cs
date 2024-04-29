namespace Blind75.LinkedList;

// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

// Merge all the linked-lists into one sorted linked-list and return it.

public static class MergeKSortedListClass
{
    public static ListNode? MergeKLists(ListNode?[] lists)
    {
        if (lists?.Length == 0)
        {
            return null;
        }

        while (lists?.Length > 1)
        {
            ListNode?[] mergedLists = new ListNode[(lists.Length + 1) / 2];
            for (int i = 0; i < lists.Length; i += 2)
            {
                ListNode? l1 = lists[i];
                ListNode? l2 = (i + 1 < lists.Length) ? lists[i + 1] : null;
                mergedLists[i / 2] = MergeTwoListClass.MergeTwoLists(l1, l2);
            }
            lists = mergedLists;
        }
        return lists?[0];
    }
}
