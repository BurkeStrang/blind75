namespace Blind75.Tests.Trees;

public class KthSmallestBST
{
    [Fact]
    public void ValidateBinarySearchTreeCorrect()
    {
        TreeNode root = new(2)
        {
            left = new TreeNode(1),
            right = new TreeNode(3)
        };

        int exp = 1;
        Assert.Equal(exp, KthSmallestBSTClass.KthSmallest(root, 1));
    }
}
