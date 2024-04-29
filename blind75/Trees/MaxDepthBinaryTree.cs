namespace Blind75.Trees;

public static class MaxDepthBinaryTreeClass
{
    public static int MaxDepth(TreeNode? root)
    {
        if (root is null)
            return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }
}
