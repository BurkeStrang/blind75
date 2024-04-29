namespace Blind75.TwoPointers;

/*

You are given an integer array height of length n.
There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.

Example:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
In this case, the max area is equal to the maximum area which is from 8 to 7 which and the min height is 7 so 7x7 = 49.

*/

public static class ContainerWithMostWaterClass
{
    public static int MaxArea(int[] height)
    {
        int left = 0,
            right = height.Length - 1,
            maxArea = 0;

        while (left < right)
        {
            int minHeight = Math.Min(height[left], height[right]);
            int area = (right - left) * minHeight;
            maxArea = Math.Max(maxArea, area);

            if (height[left] == minHeight)
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
