namespace Blind75.Tests.LinkedList;

public class MergeKList
{
    [Fact]
    public void MergeKListCorrect()
    {
        ListNode list1 = new ListNode(0);
        list1.next = new ListNode(1);
        list1.next.next = new ListNode(4);
        list1.next.next.next = new ListNode(10);

        ListNode list2 = new ListNode(2);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(11);

        ListNode list3 = new ListNode(12);

        ListNode expectedList = new ListNode(0);
        expectedList.next = new ListNode(1);
        expectedList.next.next = new ListNode(2);
        expectedList.next.next.next = new ListNode(3);
        expectedList.next.next.next.next = new ListNode(4);
        expectedList.next.next.next.next.next = new ListNode(10);
        expectedList.next.next.next.next.next!.next = new ListNode(11);
        expectedList.next.next.next.next.next!.next!.next = new ListNode(12);

        Assert.Equivalent(expectedList, MergeKSortedListClass.MergeKLists(new ListNode[] { list1, list2, list3 }));
    }
}
