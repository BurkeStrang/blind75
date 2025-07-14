namespace Blind75.Tests.LinkedList;


public class RemoveNthNode
{
    [Fact]
    public void Example1()
    {
        ListNode originalList = new ListNode(0);
        originalList.next = new ListNode(1);
        originalList.next.next = new ListNode(2);
        originalList.next.next.next = new ListNode(3);
        originalList.next.next.next.next = new ListNode(4);
        originalList.next.next.next.next.next = new ListNode(10);
        originalList.next.next.next.next.next!.next = new ListNode(11);


        ListNode expectedList = new ListNode(0);
        expectedList.next = new ListNode(1);
        expectedList.next.next = new ListNode(2);
        expectedList.next.next.next = new ListNode(3);
        expectedList.next.next.next.next = new ListNode(4);
        expectedList.next.next.next.next.next = new ListNode(11);

        ListNode? res = RemoveNthNodeClass.RemoveNthFromEnd(originalList, 2);
        expectedList.ShouldBeEquivalentTo(res);
    }

    [Fact]
    public void Example2()
    {
        ListNode originalList = new(0);
        ListNode? expectedList = null;

        ListNode? res = RemoveNthNodeClass.RemoveNthFromEnd(originalList, 1);
        res.ShouldBeEquivalentTo(expectedList);
    }
}
