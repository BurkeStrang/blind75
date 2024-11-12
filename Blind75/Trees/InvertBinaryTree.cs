namespace Blind75.Trees;

// Example 1:
// input: [4,2,7,1,3,6,9]
//
//       4
//      / \
//     2   7
//    / \ / \
//   1  3 6  9
//
// output: [4,7,2,9,6,3,1]
//
//      4
//     / \
//    7   2
//   / \ / \
//  9  6 3  1
//

public static class InvertBinaryTreeClass
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null)
            return root;
        // use tuple to swap left and right nodes
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root!.left);
        InvertTree(root.right);
        return root;
    }
}
