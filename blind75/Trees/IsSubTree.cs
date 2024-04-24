namespace blind75.Trees;

public static class IsSubTreeClass
{
    public static bool IsSubTree(TreeNode? root, TreeNode? subroot)
    {
        return root is not null
            && (
                IsSameTreeClass.IsSameTree(root, subroot)
                || IsSubTree(root.left, subroot)
                || IsSubTree(root.right, subroot)
            );
    }
}
