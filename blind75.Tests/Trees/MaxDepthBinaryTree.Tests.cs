public class MaxDepthBinaryTree
{
    [Fact]
    public void MaxDepthBinaryTreeCorrect()
    {
        TreeNode? orig = new TreeNode(0);
        orig.left = new TreeNode(1);
        orig.right = new TreeNode(2);
        orig.left.left = new TreeNode(3);

        int res = MaxDepthBinaryTreeClass.MaxDepth(orig);
        int exp = 3;
        Assert.Equivalent(exp, res);
    }
}
