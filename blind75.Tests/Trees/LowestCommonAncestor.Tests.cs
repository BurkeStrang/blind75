public class LowestCommonAncestor
{
    [Fact]
    public void LowestCommonAncestorCorrect()
    {

        TreeNode? orig = new TreeNode(5);
        orig.left = new TreeNode(0);
        orig.left.left = new TreeNode(1);
        orig.left.left.left = new TreeNode(6);
        orig.left.right = new TreeNode(2);
        orig.left.left.left = new TreeNode(3);

        TreeNode? sub1 = new TreeNode(0);
        sub1.left = new TreeNode(1);
        sub1.right = new TreeNode(2);
        sub1.left.left = new TreeNode(3);

        TreeNode? sub2 = new TreeNode(6);

        TreeNode? res = LowestCommonAncestorClass.LowestCommonAncestor(orig, sub1, sub2);
        TreeNode? exp = orig;
        Assert.Equivalent(exp, res);
    }
}
