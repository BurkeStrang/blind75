namespace Blind75.Trees;


/*

Given a binary tree, determine if it is height-balanced

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: true

Example 2:
Input: root = [1,2,2,3,3,null,null,4,4]
Output: false

Example 3:
Input: root = []
Output: true

Constraints:
The number of nodes in the tree is in the range [0, 5000].
-104 <= Node.val <= 104

*/

public static class BalancedBinaryTreeClass
{
    public static bool IsBalanced(TreeNode? root)
    {
        // If the tree is empty or
        // the height difference between left and right subtrees is less than or equal to 1
        return root is null
            || (
                Abs(Height(root.left) - Height(root.right)) <= 1
                && IsBalanced(root.left)
                && IsBalanced(root.right)
            );
    }

    private static int Height(TreeNode? node)
    {
        // If the node is null, return -1 as the height
        if (node is null)
            return -1;

        // The height of a node is the maximum height of its two children plus 1
        return Max(Height(node.left), Height(node.right)) + 1;
    }
}
