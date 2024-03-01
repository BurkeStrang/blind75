namespace blind75.LinkedList;

public static class HasCycleClass
{
    public static bool HasCycle(ListNode head)
    {
        ListNode? fast = head;
        ListNode? slow = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (slow!.Equals(fast))
                return true;
        }
        return false;
    }
}