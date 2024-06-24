namespace Blind75.Trees;

public class BinaryTreeRightSideViewTests
{
    [Fact]
    public void RightSideView_WhenCalled_ReturnsRightSideView()
    {
        // Arrange
        var sut = new RightSideViewClass();
        var root = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                right = new TreeNode(5)
            },
            right = new TreeNode(3)
            {
                right = new TreeNode(4)
            }
        };
        // Act
        var result = sut.RightSideView(root);
        // Assert
        Assert.Equal(new List<int> { 1, 3, 4 }, result);
    }
}
