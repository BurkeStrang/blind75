namespace blind75.Trees;

// A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them. A node can only appear in the sequence at most once. Note that the path does not need to pass through the root.
// The path sum of a path is the sum of the node's values in the path.
// Given the root of a binary tree, return the maximum path sum of any non-empty path.

// Input: root = [1,2,3]
// Output: 6
// Explanation: The optimal path is 2 -> 1 -> 3 with a path sum of 2 + 1 + 3 = 6.

public static class MaximumPathSumClass
{
    static int maxPathSum = int.MinValue;

    public static int MaxPathSum(TreeNode root)
    {
        DfsMaxPathSum(root);
        return maxPathSum;
    }

    static int DfsMaxPathSum(TreeNode? root)
    {
        if (root == null)
            return 0;

        int leftMax = DfsMaxPathSum(root.left),
            rightMax = DfsMaxPathSum(root.right),
            currentMax = 0;

        currentMax = Math.Max(currentMax, Math.Max(leftMax + root.val, rightMax + root.val));
        maxPathSum = Math.Max(maxPathSum, leftMax + root.val + rightMax);

        return currentMax;
    }
}
