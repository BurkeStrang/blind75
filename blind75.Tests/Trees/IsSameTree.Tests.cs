public class IsSameTree
{
    [Fact]
    public void IsSameTreeCorrect()
    {
        TreeNode? orig1 = new TreeNode(0);
        orig1.left = new TreeNode(1);
        orig1.right = new TreeNode(2);
        orig1.left.left = new TreeNode(3);

        TreeNode? orig2 = new TreeNode(0);
        orig2.left = new TreeNode(1);
        orig2.right = new TreeNode(2);
        orig2.left.left = new TreeNode(3);

        bool res = IsSameTreeClass.IsSameTree(orig1, orig2);
        bool exp = true;
        Assert.Equivalent(exp, res);
    }
}
