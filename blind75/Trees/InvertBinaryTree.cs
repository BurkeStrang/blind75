namespace blind75.Trees;

public static class InvertBinaryTreeClass
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null)
            return root;
        TreeNode? temp = root.right;
        root.right = root.left;
        root.left = temp;
        InvertTree(root!.left);
        InvertTree(root.right);
        return root;
    }
}
