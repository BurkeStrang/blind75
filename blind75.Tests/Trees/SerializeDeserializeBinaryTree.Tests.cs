public class SerializeDeserializeBinaryTree
{
    [Fact]
    public void SerializeDeserializeBinaryTreeCorrect()
    {

        TreeNode? expected = new(3);
        expected.left = new TreeNode(9);
        expected.right = new TreeNode(20);
        expected.right.left = new TreeNode(15);
        expected.right.right = new TreeNode(7);

        string s = SerializeDeserializeBinaryTreeClass.serialize(expected);
        TreeNode? res = SerializeDeserializeBinaryTreeClass.deserialize(s);

        Assert.Equivalent(expected, res);
    }
}
