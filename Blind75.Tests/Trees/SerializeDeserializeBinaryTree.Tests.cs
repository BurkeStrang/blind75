namespace Blind75.Tests.Trees;

public class SerializeDeserializeBinaryTree
{
    [Fact]
    public void SerializeDeserializeBinaryTreeCorrect()
    {

        TreeNode? expected = new(3)
        {
            left = new TreeNode(9),
            right = new TreeNode(20)
        };
        expected.right.left = new TreeNode(15);
        expected.right.right = new TreeNode(7);

        string s = SerializeDeserializeBinaryTreeClass.serialize(expected);
        TreeNode? res = SerializeDeserializeBinaryTreeClass.deserialize(s);

        Assert.Equivalent(expected, res);
    }
}
