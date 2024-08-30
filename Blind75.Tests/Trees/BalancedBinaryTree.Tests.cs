namespace Blind75.Trees;

public class BalancedBinaryTreeTests
{
    [Fact]
    public void IsBalanced_GivenExample1_ReturnsTrue()
    {
        // Arrange
        TreeNode root = new(3, new(9), new(20, new(15), new(7)));
        // Act
        bool result = BalancedBinaryTreeClass.IsBalanced(root);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsBalanced_GivenExample2_ReturnsFalse()
    {
        // Arrange
        TreeNode root = new(1, new(2, new(3, new(4), new(4)), new(3)));
        // Act
        bool result = BalancedBinaryTreeClass.IsBalanced(root);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsBalanced_GivenExample3_ReturnsTrue()
    {
        // Arrange
        TreeNode? root = null;
        // Act
        bool result = BalancedBinaryTreeClass.IsBalanced(root);
        // Assert
        Assert.True(result);
    }
}
