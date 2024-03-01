public class MaximumPathSum
{
    [Fact]
    public void ConstructBinaryTreeCorrect()
    {

        TreeNode? root = new(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        int expected = 9 + 3 + 20 + 15;

        Assert.Equivalent(expected, MaximumPathSumClass.MaxPathSum(root));
    }
}
