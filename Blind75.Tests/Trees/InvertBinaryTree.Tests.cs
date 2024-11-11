namespace Blind75.Tests.Trees;

public class InvertBinaryTree
{
    [Fact]
    public void InvertBinaryTreeCorrect()
    {
        TreeNode? orig = new(0) { left = new(1), right = new(2) };
        orig.left.left = new TreeNode(3);

        TreeNode? inv =
            new(0)
            {
                left = new(2),
                right = new(1) { right = new(3) },
            };

        TreeNode? res = InvertBinaryTreeClass.InvertTree(orig);

        Assert.Equivalent(inv, res);
    }
}
