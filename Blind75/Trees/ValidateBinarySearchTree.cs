namespace Blind75.Trees;

// Given the root of a binary tree, determine if it is a valid binary search tree (BST).

// A valid BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than the node's key.
// The right subtree of a node contains only nodes with keys greater than the node's key.
// Both the left and right subtrees must also be binary search trees.

// Binary Search Trees are found in many data structures for efficient searching and sorting.
// Sql Server uses BSTs for indexing, for example.

public static class ValidateBinarySearchTreeClass
{

    public static bool IsValidBST(TreeNode? root)
    {
        Stack<TreeNode> stack = new();
        int? prev = null;

        while (stack.Count != 0 || root != null)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            // If next element in inorder traversal
            // is smaller than the previous one
            // that's not BST.
            if (prev != null && root.val <= prev)
                return false;
            prev = root.val;
            root = root.right;
        }
        return true;
    }
}
