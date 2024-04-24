namespace blind75.Trees;

public static class InvertBinaryTreeClass
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null)
            return root;
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root!.left);
        InvertTree(root.right);
        return root;
    }
}
