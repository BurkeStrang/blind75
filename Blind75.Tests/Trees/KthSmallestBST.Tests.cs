namespace Blind75.Tests.Trees;

public class KthSmallestBST
{
    [Fact]
    public void Example1()
    {
        TreeNode root = new(2) { left = new TreeNode(1), right = new TreeNode(3) };

        int exp = 1;
        int res = KthSmallestBSTClass.KthSmallest(root, 1);
        res.Should().Be(exp);
    }

    [Fact]
    public void Example2()
    {
        TreeNode root =
            new(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2) { left = new TreeNode(1) },
                    right = new TreeNode(4),
                },
                right = new TreeNode(6),
            };
        int exp = 3;
        int res = KthSmallestBSTClass.KthSmallest(root, 3);
        res.Should().Be(exp);
    }
}
