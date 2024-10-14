namespace Blind75.Tests.LinkedList;

public class PalindromeLinkedListTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode head = new(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        // Act
        bool result = PalindromeLinkedList.IsPalindrome(head);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode head = new(1, new ListNode(2));
        // Act
        bool result = PalindromeLinkedList.IsPalindrome(head);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        ListNode head = new(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1)))));
        // Act
        bool result = PalindromeLinkedList.IsPalindrome(head);
        // Assert
        Assert.True(result);
    }
}
