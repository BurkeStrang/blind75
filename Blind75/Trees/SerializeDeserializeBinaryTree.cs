namespace Blind75.Trees;

public static class SerializeDeserializeBinaryTreeClass
{
    static List<string>? encodedList { get; set; }

    // Encodes a tree to a single string.
    public static string serialize(TreeNode? root)
    {
        encodedList = new List<string>();

        static void dfs(TreeNode? root)
        {
            if (root == null)
            {
                encodedList!.Add("N");
                return;
            }

            encodedList!.Add(root.val + "");
            dfs(root.left);
            dfs(root.right);
        }

        dfs(root);
        return string.Join(",", encodedList);
    }

    // Decodes your encoded data to tree.
    public static TreeNode? deserialize(string data)
    {
        var nodesArray = data.Split(",");
        var index = 0;

        TreeNode? dfs()
        {
            if (nodesArray[index] == "N")
            {
                index++;
                return null;
            }

            var newNode = new TreeNode(int.Parse(nodesArray[index]));
            index++;
            newNode.left = dfs();
            newNode.right = dfs();
            return newNode;
        }

        return dfs();
    }
}
