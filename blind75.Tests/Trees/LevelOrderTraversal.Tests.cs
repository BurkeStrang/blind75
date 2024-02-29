public class LevelOrderTraversal
{
    [Fact]
    public void LevelOrderTraversalCorrect()
    {

        TreeNode? orig = new TreeNode(5);
        orig.left = new TreeNode(0);
        orig.left.left = new TreeNode(1);
        orig.left.left.left = new TreeNode(6);
        orig.left.right = new TreeNode(2);
        orig.left.left.right = new TreeNode(3);

        IList<IList<int>> res = LevelOrderTraversalClass.LevelOrder(orig);
        IList<IList<int>> exp = new List<IList<int>>();
        exp.Add(new List<int>() { 5 });
        exp.Add(new List<int>() { 0 });
        exp.Add(new List<int>() { 1, 2 });
        exp.Add(new List<int>() { 6, 3 });
        Assert.Equivalent(exp, res);
    }
}
