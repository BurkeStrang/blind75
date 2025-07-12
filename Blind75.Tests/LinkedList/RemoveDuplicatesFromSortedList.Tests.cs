namespace Blind75.Tests.LinkedList;

public class RemoveDuplicatesFromSortedListTests
{
    [Fact]
    public void Example1()
    {
        ListNode? input = new(1, new(1, new(2)));
        ListNode? expected = new(1, new(2));
        ListNode? result = RemoveDuplicatesFromSortedList.DeleteDuplicates(input);
        result.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        ListNode? input = new(1, new(1, new(2, new(3, new(3)))));
        ListNode? expected = new(1, new(2, new(3)));
        ListNode? result = RemoveDuplicatesFromSortedList.DeleteDuplicates(input);
        result.ShouldBeEquivalentTo(expected);
    }
}
