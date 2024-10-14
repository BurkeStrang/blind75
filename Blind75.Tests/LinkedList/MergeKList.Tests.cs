namespace Blind75.Tests.LinkedList;

public class MergeKList
{
    [Fact]
    public void MergeKListCorrect()
    {
        ListNode list1 = new(0)
        {
            next = new ListNode(1)
        };
        list1.next.next = new ListNode(4)
        {
            next = new ListNode(10)
        };

        ListNode list2 = new(2)
        {
            next = new ListNode(3)
            {
                next = new ListNode(11)
            }
        };

        ListNode list3 = new(12);

        ListNode expectedList = new(0)
        {
            next = new ListNode(1)
        };
        expectedList.next.next = new ListNode(2)
        {
            next = new ListNode(3)
        };
        expectedList.next.next.next.next = new ListNode(4)
        {
            next = new ListNode(10)
        };
        expectedList.next.next.next.next.next!.next = new ListNode(11);
        expectedList.next.next.next.next.next!.next!.next = new ListNode(12);

        Assert.Equivalent(expectedList, MergeKSortedListClass.MergeKLists([list1, list2, list3]));
    }
}
