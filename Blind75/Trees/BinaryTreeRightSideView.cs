namespace Blind75.Trees;

// Given a binary tree, write a function that returns the values of the nodes
// you can see ordered from top to bottom when looking at the tree from the right side.
//
// Example 1 :
// Input: [1,2,3,null,5,null,4]
// Output: [1,3,4]
//
// Explanation:
//    1            <---
//  /   \
// 2     3         <---
//  \     \
//   5     4       <---
//
//
// org [1, 2, 3, 4, 5, 6, 8, 7]
// tree structure
// only what you can see from the right side
//                     1      <---
//                  /     \
//                /        \
//              2           3   <---
//            /  \         / \
//           4    5       6   8  <---
//                 \
//                  7          <---

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
