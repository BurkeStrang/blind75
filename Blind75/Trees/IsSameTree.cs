namespace Blind75.Trees;

public static class IsSameTreeClass
{
    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        return p is null && q is null
            || (IsSameTree(p?.left, q?.left) && IsSameTree(p?.right, q?.right) && p?.val == q?.val);
    }
}
