namespace Blind75.Shared;

public class ListNode
{
    public int val;
    public ListNode? random;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null, ListNode? random = null)
    {
        this.val = val;
        this.next = next;
        this.random = random;
    }
}
