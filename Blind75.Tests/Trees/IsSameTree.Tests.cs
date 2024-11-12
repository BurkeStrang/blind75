namespace Blind75.Tests.Trees;

public class IsSameTree
{
    [Fact]
    public void IsSameTreeCorrect()
    {
        TreeNode? orig1 = new(0)
        {
            left = new TreeNode(1),
            right = new TreeNode(2)
        };
        orig1.left.left = new TreeNode(3);

        TreeNode? orig2 = new(0)
        {
            left = new TreeNode(1),
            right = new TreeNode(2)
        };
        orig2.left.left = new TreeNode(3);

        bool res = IsSameTreeClass.IsSameTree(orig1, orig2);
        bool exp = true;
        Assert.Equivalent(exp, res);
    }
}
