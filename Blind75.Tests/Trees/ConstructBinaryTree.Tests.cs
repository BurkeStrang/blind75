namespace Blind75.Tests.Trees;

public class ConstructBinaryTree
{
    [Fact]
    public void ConstructBinaryTreeCorrect()
    {
        // Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
        // Output: [3,9,20,null,null,15,7]
        int[] preorder = [3, 9, 20, 15, 7];
        int[] inorder = [9, 3, 15, 20, 7];

        TreeNode? expected = new(3) { left = new(9), right = new(20) };
        expected.right.left = new(15);
        expected.right.right = new(7);

        Assert.Equivalent(expected, ConstructBinaryTreeClass.BuildTree(preorder, inorder));
    }
}
