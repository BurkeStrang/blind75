namespace blind75.Trees;

// Given the root of a binary search tree, and an integer k,
// return the kth smallest value (1-indexed) of all
// the values of the nodes in the tree.

public static class KthSmallestBSTClass
{
    public static int KthSmallest(TreeNode? root, int k)
    {
        int result = -1;
        Stack<TreeNode> inorderStack = new();

        TreeNode? cur = root;

        while (cur != null || inorderStack.Count > 0)
        {
            while (cur != null)
            {
                inorderStack.Push(cur);
                cur = cur.left;
            }
            cur = inorderStack.Pop();

            k--;
            if (k == 0)
            {
                result = cur.val;
                break;
            }
            cur = cur.right;
        }
        return result;
    }
}
