namespace Blind75.Shared;

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
#pragma warning disable IDE1006 // Naming Styles
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
#pragma warning restore IDE1006 // Naming Styles
}
