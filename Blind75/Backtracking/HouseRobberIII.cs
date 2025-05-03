namespace Blind75.Backtracking;

public static class HouseRobberIII
{
    public static int Rob(TreeNode root)
    {
        return GetMaxRobAmount(root);
    }

    private static int GetMaxRobAmount(TreeNode? node)
    {
        if (node == null)
            return 0;

        int rob = node.val;
        if (node.left != null)
        {
            rob += GetMaxRobAmount(node?.left?.left) + GetMaxRobAmount(node?.left.right);
        }
        if (node?.right != null)
        {
            rob += GetMaxRobAmount(node.right.left) + GetMaxRobAmount(node.right.right);
        }

        return Max(rob, GetMaxRobAmount(node?.left) + GetMaxRobAmount(node?.right));
    }

}

