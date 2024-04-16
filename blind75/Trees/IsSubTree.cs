namespace blind75.Trees;

public static class IsSubTreeClass
{
    public static bool IsSubTree(TreeNode? root, TreeNode? subroot)
    {
        if (root is null)
            return false;
        if (IsSameTreeClass.IsSameTree(root, subroot))
            return true;
        return IsSubTree(root.left, subroot) || IsSubTree(root.right, subroot);
    }
}


