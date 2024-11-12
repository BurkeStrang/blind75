namespace Blind75.Tests.Trees;

public class LowestCommonAncestor
{
    [Fact]
    public void LowestCommonAncestorCorrect()
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
        orig.left.left.left = new TreeNode(3);

        TreeNode? sub1 = new(0)
        {
            left = new TreeNode(1),
            right = new TreeNode(2)
        };
        sub1.left.left = new TreeNode(3);

        TreeNode? sub2 = new(6);

        TreeNode? res = LowestCommonAncestorClass.LowestCommonAncestor(orig, sub1, sub2);
        TreeNode? exp = orig;
        Assert.Equivalent(exp, res);
    }
}
