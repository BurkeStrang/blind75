namespace Blind75.LinkedList;

public static class HasCycleClass
{
    public static bool HasCycle(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while(fast.next is not null && fast.next!.next is not null)
        {
            slow = slow!.next;
            fast = fast.next.next;
            if(fast == slow)
                return true;
        }
        return false;
    }
}
