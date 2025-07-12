namespace Blind75.Tests.Trees;

public class InvertBinaryTree
{
    [Fact]
    public void Example1()
    {
        TreeNode? orig =
            new(4)
            {
                left = new(2) { left = new(1), right = new(3) },
                right = new(7) { left = new(6), right = new(9) },
            };
        TreeNode? inv =
            new(4)
            {
                left = new(7) { left = new(9), right = new(6) },
                right = new(2) { left = new(3), right = new(1) },
            };
        TreeNode? res = InvertBinaryTreeClass.InvertTree(orig);

        inv.ShouldBeEquivalentTo(res);
    }

    [Fact]
    public void Example2()
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

        inv.ShouldBeEquivalentTo(res);
    }
}
