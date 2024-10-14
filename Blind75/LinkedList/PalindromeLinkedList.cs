namespace Blind75.LinkedList;

// Given the head of a singly linked list, return true if it is a
// palindrome or false otherwise.
//
// Example 1:
// Input: head = [1,2,2,1]
// Output: true
//
// Example 2:
// Input: head = [1,2]
// Output: false
//
// Constraints:
// The number of nodes in the list is in the range [1, 105].
// 0 <= Node.val <= 9
//
// Follow up: Could you do it in O(n) time and O(1) space?

public static class PalindromeLinkedList
{
    public static bool IsPalindrome(ListNode? head)
    {
        //find middle
        ListNode? fast = head;
        ListNode? slow = head;

        while(fast is not null && fast?.next is not null)
        {
            slow = slow?.next!;
            fast = fast?.next!?.next!;
        }
        //reverse second half
        ListNode? reverserdList = ReverseLinkedListClass.ReverseList(slow);

        //compare to first half
        while(reverserdList is not null)
        {
            if(reverserdList!?.val != head!?.val)
                return false;
            reverserdList = reverserdList?.next;
            head = head!?.next;
        }
        return true;
    }
}
