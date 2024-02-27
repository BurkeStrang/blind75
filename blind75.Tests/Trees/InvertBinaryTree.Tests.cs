public class InvertBinaryTree
{
    [Fact]
    public void InvertBinaryTreeCorrect()
    {
        TreeNode? orig = new TreeNode(0);
        orig.left = new TreeNode(1);
        orig.right = new TreeNode(2);
        orig.left.left = new TreeNode(3);

        TreeNode? inv = new TreeNode(0);
        inv.left = new TreeNode(2);
        inv.right = new TreeNode(1);
        inv.right.right = new TreeNode(3);

        TreeNode? res = InvertBinaryTreeClass.InvertTree(orig);

        Assert.Equivalent(inv, res);
    }
}
