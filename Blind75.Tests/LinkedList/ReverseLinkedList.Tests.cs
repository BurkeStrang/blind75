namespace Blind75.Tests.LinkedList;

public class ReverseLinkedList
{
    [Fact]
    public void ReverseLinkedListCorrect()
    {
        ListNode list = new(0)
        {
            next = new(1)
            {
                next = new(2)
            }

        };

        ListNode reversedList = new(2)
        {
            next = new(1)
            {
                next = new(0)
            }
        };

        reversedList.Should().BeEquivalentTo(ReverseLinkedListClass.ReverseList(list));
    }

    [Fact]
    public void ReverseLinkedListEmpty()
    {
        ListNode? list = null;
        ListNode? reversedList = null;
        reversedList!.Should().BeEquivalentTo(ReverseLinkedListClass.ReverseList(list));
    }

    [Fact]
    public void ReverseLinkedListRecursiveCorrect()
    {
        ListNode list = new(0)
        {
            next = new(1)
            {
                next = new(2)
            }
        };
        ListNode reversedList = new(2)
        {
            next = new(1)
            {
                next = new(0)
            }
        };
        reversedList.Should().BeEquivalentTo(ReverseLinkedListClass.ReverseListRecursive(list));
    }
}
