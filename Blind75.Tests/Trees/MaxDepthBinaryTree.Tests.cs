namespace Blind75.Tests.Trees;

public class MaxDepthBinaryTree
{
    [Fact]
    public void MaxDepthBinaryTreeCorrect()
    {
        TreeNode? orig = new(0)
        {
            left = new TreeNode(1),
            right = new TreeNode(2)
        };
        orig.left.left = new TreeNode(3);

        int res = MaxDepthBinaryTreeClass.MaxDepth(orig);
        int exp = 3;
        Assert.Equivalent(exp, res);
    }
}
