namespace Blind75.Trees;

// Given the root of a binary tree, return the level order traversal of its nodes' values. 
// (i.e., from left to right, level by level).
// Input: root = [3,9,20,null,null,15,7]
// Output: [[3],[9,20],[15,7]]

public static class LevelOrderTraversalClass
{
    private static readonly List<IList<int>> Res = [];

    public static IList<IList<int>> LevelOrder(TreeNode? root)
    {
        if (root != null)
            Helper(root, 0);
        return Res;
    }

    public static void Helper(TreeNode? root, int level)
    {
        if (Res.Count == level)
            Res.Add([]);
        Res[level].Add(root!.val);
        if (root.left != null)
            Helper(root.left, level + 1);
        if (root.right != null)
            Helper(root.right, level + 1);
    }
}
