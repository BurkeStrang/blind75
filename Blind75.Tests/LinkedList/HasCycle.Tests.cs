namespace Blind75.Tests.LinkedList;

public class HasCycle
{
    [Fact]
    public void HasCycleCorrect()
    {
        ListNode list1 = new(0)
        {
            next = new ListNode(1)
        };
        list1.next.next = new ListNode(4)
        {
            next = new ListNode(10)
        };
        list1.next.next.next.next = list1.next.next;

        Assert.True(HasCycleClass.HasCycle(list1));
    }

    [Fact]
    public void HasCycleCorrect2()
    {
        ListNode list1 = new(0)
        {
            next = new ListNode(1)
        };
        list1.next.next = new ListNode(4)
        {
            next = new ListNode(10)
        };

        Assert.False(HasCycleClass.HasCycle(list1));
    }
}
