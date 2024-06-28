using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Blind75.TwoPointers;

/*

Given n non-negative integers representing an elevation map where the width of each bar is 1,
compute how much water it can trap after raining.

Example 1:
Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Visual representation:

              #
      # + + + # # + #
  # + # # + # # # # # #
0 1 0 2 1 0 1 3 2 1 2 1

Explanation: The above elevation map (# section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
In this case, 6 units of rain water (+ section) are being trapped.

Example 2:
Input: height = [4,2,0,3,2,5]
Output: 9
Visual representation:

          #
# + + + + #
# + + # + #
# # + # # #
# # + # # #
4 2 0 3 2 5

Explanation: The above elevation map (# section) is represented by array [4,2,0,3,2,5].
In this case, 9 units of rain water (+ section) are being trapped.

 */

public static class TrappingRainWater
{
    public static int Trap(int[] height)
    {
        if (height is null || height.Length == 0)
            return 0;

        int left = 0;
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        int result = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                result += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                result += rightMax - height[right];
            }
        }
        return result;
    }
}
