namespace Blind75.Tests.Trees;

public class DiameterOfBinaryTreeTests
{
    [Fact]
    public void DiameterOfBinaryTree_GivenExample1_Returns3()
    {
        // Arrange
        TreeNode root = new(1, new(2, new(4), new(5)), new(3));
        // Act
        int result = DiameterOfBinaryTreeClass.DiameterOfBinaryTree(root);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void DiameterOfBinaryTree_GivenExample2_Returns1()
    {
        // Arrange
        TreeNode root = new(1, new(2));
        // Act
        int result = DiameterOfBinaryTreeClass.DiameterOfBinaryTree(root);
        // Assert
        Assert.Equal(1, result);
    }
}
