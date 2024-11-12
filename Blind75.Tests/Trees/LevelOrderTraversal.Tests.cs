namespace Blind75.Tests.Trees;

public class LevelOrderTraversal
{
    [Fact]
    public void LevelOrderTraversalCorrect()
    {

        TreeNode? orig = new(5)
        {
            left = new TreeNode(0)
        };
        orig.left.left = new TreeNode(1)
        {
            left = new TreeNode(6)
        };
        orig.left.right = new TreeNode(2);
        orig.left.left.right = new TreeNode(3);

        IList<IList<int>> res = LevelOrderTraversalClass.LevelOrder(orig);
        IList<IList<int>> exp = [[5], [0], [1, 2], [6, 3]];
        Assert.Equivalent(exp, res);
    }
}
