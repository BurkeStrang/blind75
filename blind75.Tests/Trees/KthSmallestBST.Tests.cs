public class KthSmallestBST
{
    [Fact]
    public void ValidateBinarySearchTreeCorrect()
    {
        TreeNode root = new(2);
        root.left = new TreeNode(1);
        root.right = new TreeNode(3);

        int exp = 1;
        Assert.Equal(exp, KthSmallestBSTClass.KthSmallest(root, 1));
    }
}
