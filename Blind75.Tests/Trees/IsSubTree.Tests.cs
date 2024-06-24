public class IsSubTree
{
    [Fact]
    public void IsSubTreeCorrect()
    {

        TreeNode? orig1 = new TreeNode(5);
        orig1.left = new TreeNode(0);
        orig1.left.left = new TreeNode(1);
        orig1.left.right = new TreeNode(2);
        orig1.left.left.left = new TreeNode(3);

        TreeNode? orig2 = new TreeNode(0);
        orig2.left = new TreeNode(1);
        orig2.right = new TreeNode(2);
        orig2.left.left = new TreeNode(3);

        bool res = IsSubTreeClass.IsSubTree(orig1, orig2);
        bool exp = true;
        Assert.Equal(exp, res);
    }
}
