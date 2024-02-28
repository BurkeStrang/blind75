namespace blind75.Trees;

public static class LowestCommonAncestorClass
{
    public static TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        int? parentVal = root?.val, pVal = p?.val, qVal = q?.val;

        if (pVal > parentVal && qVal > parentVal)
        {
            return LowestCommonAncestor(root?.right, p, q);
        }
        if (pVal < parentVal && qVal < parentVal)
        {
            return LowestCommonAncestor(root?.left, p, q);
        }
        return root;
    }
}
