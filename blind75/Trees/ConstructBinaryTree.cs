namespace Blind75.Trees;

// Given two integer arrays preorder and inorder where preorder is the preorder traversal
// of a binary tree and inorder is the inorder traversal of the same tree, construct and
// return the binary tree.

public static class ConstructBinaryTreeClass
{

    public static TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        return BuildTreeHelper(0, 0, inorder.Length - 1, preorder, inorder);
    }
    private static TreeNode? BuildTreeHelper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 && inorder.Length == 0)
            return null;

        if (preStart > preorder.Length - 1 || inStart > inEnd)
            return null;

        var rootNode = new TreeNode(preorder[preStart]);
        var mid = Array.IndexOf(inorder, preorder[preStart]);

        rootNode.left = BuildTreeHelper(preStart + 1, inStart, mid - 1, preorder, inorder);
        rootNode.right = BuildTreeHelper(preStart + mid - inStart + 1, mid + 1, inEnd, preorder, inorder);

        return rootNode;
    }
}
