public class ValidateBinarySearchTree
{
    [Fact]
    public void ValidateBinarySearchTreeCorrect()
    {
        TreeNode root = new(2);
        root.left = new TreeNode(1);
        root.right = new TreeNode(3);

        Assert.True(ValidateBinarySearchTreeClass.IsValidBST(root));
    }
}
