namespace Blind75.Shared;

public class ListNode(int val = 0, ListNode? next = null, ListNode? random = null)
{
#pragma warning disable IDE1006 // Naming Styles
    public int val = val;
    public ListNode? random = random;
    public ListNode? next = next;
#pragma warning restore IDE1006 // Naming Styles
}
