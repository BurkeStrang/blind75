namespace Blind75.Tests.Trees;

public class IsSubTree
{
    [Fact]
    public void IsSubTreeCorrect()
    {

        TreeNode? orig1 = new(5)
        {
            left = new TreeNode(0)
            {
                left = new TreeNode(1),
                right = new TreeNode(2)
            }
        };
        orig1.left.left.left = new TreeNode(3);

        TreeNode? orig2 = new(0)
        {
            left = new TreeNode(1),
            right = new TreeNode(2)
        };
        orig2.left.left = new TreeNode(3);

        bool res = IsSubTreeClass.IsSubTree(orig1, orig2);
        bool exp = true;
        Assert.Equal(exp, res);
    }
}
