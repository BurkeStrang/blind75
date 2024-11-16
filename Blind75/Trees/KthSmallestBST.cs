namespace Blind75.Trees;

// Given the root of a binary search tree, and an integer k,
// return the kth smallest value (1-indexed) of all
// the values of the nodes in the tree.
//
// Example 1:
// input: root = [3,1,4,null,2], k = 1
//
//           3
//         /  \
//        1    4
//         \
//          2
// output: 1
//
// Example 2:
// input: root = [5,3,6,2,4,null,null,1], k = 3
//
//          5
//        /   \
//       3    6
//      / \
//     2  4
//    /
//   1
// output: 3

public static class KthSmallestBSTClass
{
    public static int KthSmallest(TreeNode? root, int k)
    {
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

            if (--k == 0)
                return cur.val;

            cur = cur.right;
        }
        return -1;
    }
}
