namespace Blind75.Trees;

public class CountGoodNodesInBinaryTreeTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        CountGoodNodesInBinaryTree sut = new();
        TreeNode root =
            new(3)
            {
                left = new TreeNode(1) { left = new TreeNode(3) },
                right = new TreeNode(4) { left = new TreeNode(1), right = new TreeNode(5) }
            };
        // Act
        int result = sut.GoodNodes(root);
        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        CountGoodNodesInBinaryTree sut = new();
        TreeNode root =
            new(3)
            {
                left = new TreeNode(3) { right = new TreeNode(2) },
                right = new TreeNode(4)
            };
        // Act
        int result = sut.GoodNodes(root);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        CountGoodNodesInBinaryTree sut = new();
        TreeNode root = new(1);
        // Act
        int result = sut.GoodNodes(root);
        // Assert
        Assert.Equal(1, result);
    }
}
