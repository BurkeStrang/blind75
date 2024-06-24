namespace Blind75.Trees;

public static class IsSubTreeClass
{
    public static bool IsSubTree(TreeNode? root, TreeNode? subroot)
    {
        return root is not null
            && (
                // check if the root is same as subroot
                IsSameTreeClass.IsSameTree(root, subroot)
                // check if the left subtree is same as subroot
                || IsSubTree(root.left, subroot)
                // check if the right subtree is same as subroot
                || IsSubTree(root.right, subroot)
            );
    }
}
