namespace Blind75.Tests.Trees;

public class ValidateBinarySearchTree
{
    [Fact]
    public void ValidateBinarySearchTreeCorrect()
    {
        TreeNode root = new(2)
        {
            left = new TreeNode(1),
            right = new TreeNode(3)
        };

        Assert.True(ValidateBinarySearchTreeClass.IsValidBST(root));
    }
}
