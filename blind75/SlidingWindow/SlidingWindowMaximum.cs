namespace Blind75.SlidingWindow;

/*

You are given an array of integers nums,
there is a sliding window of size k which is moving from the very left of the array to the very right.
You can only see the k numbers in the window. Each time the sliding window moves right by one position.
Return the max sliding window.

Example 1:
Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation:
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7

Example 2:
Input: nums = [1], k = 1
Output: [1]

*/

public static class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        // Output list to store the maximum values of each window
        List<int> output = [];
        // linkedlist with first and last pointers to store indices of the array elements
        LinkedList<int> list = new();

        int left = 0;
        int right = 0;

        while (right < nums.Length)
        {
            // Remove elements from the deque that are smaller than the current element
            while (list.Count > 0 && nums[list!.Last!.Value] < nums[right])
                list.RemoveLast();
            // Add the current element's index to the deque
            list.AddLast(right);

            // Remove the element from the deque if it's outside the window
            if (left > list!.First!.Value)
                list.RemoveFirst();

            // Once we've hit the size of the window, start adding max values to the output
            if (right + 1 >= k)
            {
                output.Add(nums[list.First.Value]);
                left++;
            }

            right++;
        }

        return [.. output];
    }
}
