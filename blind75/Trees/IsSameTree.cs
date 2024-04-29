namespace Blind75.Trees;

public static class IsSameTreeClass
{
    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        return p == null && q == null
            || (
                p != null
                && q != null
                && p.val == q.val
                && IsSameTree(p.left, q.left)
                && IsSameTree(p.right, q.right)
            );
    }
}
