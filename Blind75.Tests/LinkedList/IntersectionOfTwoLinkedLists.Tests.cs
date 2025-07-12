namespace Blind75.Tests.LinkedList;

public class IntersectionOfTwoLinkedListsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        ListNode intersect = new(8, new(4, new(5)));
        ListNode headA = new(4, new(1, intersect));
        ListNode headB = new(5, new(0, intersect));
        ListNode expected = new(8, new(4, new(5)));

        // Act
        ListNode? result = IntersectionOfTwoLinkedLists.GetIntersectionNode(headA, headB);

        // Assert
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        ListNode intersect = new(2, new(4));
        ListNode headA = new(0, new(9, new(1, intersect)));
        ListNode headB = new(3, intersect);
        ListNode expected = new(2, new(4));

        // Act
        ListNode? result = IntersectionOfTwoLinkedLists.GetIntersectionNode(headA, headB);

        // Assert
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        ListNode headA = new(2, new(6, new(4)));
        ListNode headB = new(1, new(5));
        ListNode? expected = null;

        // Act
        ListNode? result = IntersectionOfTwoLinkedLists.GetIntersectionNode(headA, headB);

        // Assert
        result.ShouldBeEquivalentTo(expected);
    }
}
