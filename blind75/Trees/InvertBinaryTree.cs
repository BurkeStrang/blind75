namespace Blind75.Trees;

public static class InvertBinaryTreeClass
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null)
            return root;
        // use tuple to swap left and right nodes
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root!.left);
        InvertTree(root.right);
        return root;
    }
}
