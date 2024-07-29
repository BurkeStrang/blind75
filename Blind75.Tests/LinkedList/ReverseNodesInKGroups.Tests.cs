namespace Blind75.Tests.LinkedList;

public class ReverseNodesInKGroupsTests
{
    [Fact]
    public void Example1()
    {
        ListNode? head = new(1, new(2, new(3, new(4, new(5)))));
        int k = 2;
        ListNode? expected = new(2, new(1, new(4, new(3, new(5)))));
        ListNode? actual = ReverseNodesInKGroups.ReverseKGroup(head, k);
        actual.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Example2()
    {
        ListNode? head = new(1, new(2, new(3, new(4, new(5)))));
        int k = 3;
        ListNode? expected = new(3, new(2, new(1, new(4, new(5)))));
        ListNode? actual = ReverseNodesInKGroups.ReverseKGroup(head, k);
        actual.Should().BeEquivalentTo(expected);
    }

}
