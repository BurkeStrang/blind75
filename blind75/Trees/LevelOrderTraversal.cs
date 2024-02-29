namespace blind75.Trees;

// Given the root of a binary tree, return the level order traversal of its nodes' values. 
// (i.e., from left to right, level by level).
// Input: root = [3,9,20,null,null,15,7]
// Output: [[3],[9,20],[15,7]]

public static class LevelOrderTraversalClass
{
    private static List<IList<int>> res = new();

    public static IList<IList<int>> LevelOrder(TreeNode? root)
    {
        if (root != null)
            helper(root, 0);
        return res;
    }

    public static void helper(TreeNode? root, int level)
    {
        if (res.Count == level)
            res.Add(new List<int>());
        res[level].Add(root!.val);
        if (root.left != null)
            helper(root.left, level + 1);
        if (root.right != null)
            helper(root.right, level + 1);
    }
}
