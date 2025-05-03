namespace Blind75.Tests.Backtracking;

public class HouseRobberIIITests
{
    [Fact]
    public void TestRob_SimpleTree_ReturnsMaxAmount()
    {
        // Arrange
        TreeNode root = new(3)
        {
            left = new TreeNode(2)
            {
                right = new TreeNode(3)
            },
            right = new TreeNode(3)
            {
                right = new TreeNode(1)
            }
        };

        // Act
        int result = HouseRobberIII.Rob(root);

        // Assert
        Assert.Equal(7, result); // Expected max amount is 7 (3 + 3 + 1)
    }
}
