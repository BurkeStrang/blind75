namespace Blind75.LinkedList;
/*

You are given two non-empty linked lists representing two non-negative integers.
The digits are stored in reverse order, and each of their nodes contains a single digit.
Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:
Input: l1 = [0], l2 = [0]
Output: [0]
Explanation: 0 + 0 = 0.

Example 3:
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
Explanation: 9999999 + 9999 = 10009998

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.

*/
public static class AddTwoNumbersClass
{
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode sumList = new();
        ListNode current = sumList;
        int carry = 0;

        while(l1 is not null || l2 is not null || carry == 1)
        {
            int l1v = l1 is null ? 0 : l1.val;
            int l2v = l2 is null ? 0 : l2.val;
            int sum = l1v + l2v + carry;
            carry = sum > 9 ? 1 : 0;
            sum %= 10;

            current.next = new(sum);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return sumList.next;
    }
}
