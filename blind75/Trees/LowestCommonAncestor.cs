namespace Blind75.Trees;

public static class LowestCommonAncestorClass
{
    public static TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        int? parentVal = root?.val,
            pVal = p?.val,
            qVal = q?.val;

        return pVal > parentVal && qVal > parentVal
            ? LowestCommonAncestor(root?.right, p, q)
            : pVal < parentVal && qVal < parentVal
                ? LowestCommonAncestor(root?.left, p, q)
                : root;
    }
}
