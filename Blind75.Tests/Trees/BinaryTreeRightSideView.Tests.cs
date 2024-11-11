namespace Blind75.Tests.Trees;

public class BinaryTreeRightSideViewTests
{
    [Fact]
    public void RightSideView_WhenCalled_ReturnsRightSideView()
    {
        // Arrange
        RightSideViewClass sut = new();
        TreeNode root =
            new(1)
            {
                left = new TreeNode(2) { right = new TreeNode(5) },
                right = new TreeNode(3) { right = new TreeNode(4) },
            };
        // Act
        IList<int> result = sut.RightSideView(root);
        // Assert
        Assert.Equal([1, 3, 4], result);
    }

    [Fact]
    public void RightSideView_WhenCalledWithNull_ReturnsEmptyList()
    {
        // Arrange
        RightSideViewClass sut = new();
        // Act
        IList<int> result = sut.RightSideView(null);
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void RightSideView_WhenCalledWithSingleNode_ReturnsSingleNode()
    {
        // Arrange
        RightSideViewClass sut = new();
        TreeNode root = new(1);
        // Act
        IList<int> result = sut.RightSideView(root);
        // Assert
        Assert.Equal([1], result);
    }

    [Fact]
    public void RightSideView_WhenCalledWithSingleNodeAndRightChild_ReturnsSingleNode()
    {
        // Arrange
        RightSideViewClass sut = new();
        TreeNode root = new(1) { right = new TreeNode(2) };
        // Act
        IList<int> result = sut.RightSideView(root);
        // Assert
        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void RightSideView_WhenCalledWithComplexTree_ReturnsRightSideView()
    {
        // Arrange
        RightSideViewClass sut = new();
        TreeNode root =
            new(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4) { right = new TreeNode(7) },
                    right = new TreeNode(5),
                },
                right = new TreeNode(3)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(8),
                },
            };
        // Act
        IList<int> result = sut.RightSideView(root);
        // Assert
        Assert.Equal([1, 3, 8, 7], result);

    }
}
