namespace Blind75.Trees;

public class RightSideViewClass
{
    private readonly List<int> _result = [];

    public IList<int> RightSideView(TreeNode? root)
    {
        Dfs(root, 0);
        return _result;
    }

    private void Dfs(TreeNode? root, int level)
    {
        if (root == null)
            return;
        if (level >= _result.Count)
            _result.Add(root.val);

        // At first visit right node
        Dfs(root.right, level + 1);
        Dfs(root.left, level + 1);
    }
}
