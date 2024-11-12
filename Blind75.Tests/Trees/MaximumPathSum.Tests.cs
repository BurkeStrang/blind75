namespace Blind75.Tests.Trees;

public class MaximumPathSum
{
    [Fact]
    public void ConstructBinaryTreeCorrect()
    {

        TreeNode? root = new(3)
        {
            left = new TreeNode(9),
            right = new TreeNode(20)
            {
                left = new TreeNode(15),
                right = new TreeNode(7)
            }
        };

        int expected = 9 + 3 + 20 + 15;

        Assert.Equivalent(expected, MaximumPathSumClass.MaxPathSum(root));
    }
}
