namespace Blind75.Shared;

public static class Extensions
{

    public static void DumpTreeNode(this TreeNode? root)
    {
        if (root is null)
            return;
        root.val.Dump("TreeNode");
        DumpTreeNode(root!.left);
        DumpTreeNode(root.right);
    }

    public static void DumpListNode(this ListNode? head, HashSet<ListNode>? visited = null)
    {
        if (head is null)
            return;

        visited ??= [];

        if (visited.Contains(head))
            return;

        visited.Add(head);
        head.val.Dump("ListNode");
        DumpListNode(head.next, visited);
        DumpListNode(head.random, visited);
    }


    public static bool AreEqual(this ListNode? head1, ListNode? head2)
    {
        while (head1 != null && head2 != null)
        {
            if (head1.val != head2.val)
                return false;
            if (head1.random != null && head2.random != null)
            {
                if (head1.random.val != head2.random.val)
                    return false;
            }
            else if (head1.random != null || head2.random != null)
            {
                return false;
            }
            head1 = head1.next;
            head2 = head2.next;
        }
        return head1 == null && head2 == null;
    }
}
