namespace Blind75.Stack;

/*

Given an array of integers heights representing the histogram's bar height where the width of each bar is 1,
return the area of the largest rectangle in the histogram.

Example 1:
Input: heights = [2,1,5,6,2,3]
Output: 10
Explanation: The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.

Example 2:
Input: heights = [2,4]
Output: 4

Constraints:

1 <= heights.length <= 105
0 <= heights[i] <= 104

*/

public static class LargestRectangleHistogram
{
    public static int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length,
            max = 0;
        Stack<int> stack = new();
        for (int i = 0; i <= n; i++)
        {
            int height = i < n ? heights[i] : 0;
            while (stack.Count != 0 && heights[stack.Peek()] > height)
            {
                int currHeight = heights[stack.Pop()];
                int prevIndex = stack.Count == 0 ? -1 : stack.Peek();
                max = Max(max, currHeight * (i - 1 - prevIndex));
            }
            stack.Push(i);
        }

        return max;
    }
}
