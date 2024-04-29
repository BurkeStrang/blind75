namespace Blind75.Shared;

public static class Extensions
{

    public static void DumpTreeNode(this TreeNode? root)
    {
        if (root is null)
            return;
        root.val.Dump("TreeNode");
        DumpTreeNode(root!.left);
        DumpTreeNode(root.right);
    }
}
