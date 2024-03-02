public class MergeTwoList
{
    [Fact]
    public void MergeTwoListCorrect()
    {
        ListNode list1 = new ListNode(0);
        list1.next = new ListNode(1);
        list1.next.next = new ListNode(4);
        list1.next.next.next = new ListNode(10);

        ListNode list2 = new ListNode(2);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(11);

        ListNode expectedList = new ListNode(0);
        expectedList.next = new ListNode(1);
        expectedList.next.next = new ListNode(2);
        expectedList.next.next.next = new ListNode(3);
        expectedList.next.next.next.next = new ListNode(4);
        expectedList.next.next.next.next.next = new ListNode(10);
        expectedList.next.next.next.next.next!.next = new ListNode(11);

        Assert.Equivalent(expectedList, MergeTwoListClass.MergeTwoLists(list1, list2));
    }
}
