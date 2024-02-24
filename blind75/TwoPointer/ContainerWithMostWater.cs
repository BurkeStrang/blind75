namespace blind75.TwoPointers;

public static class ContainerWithMostWaterClass
{
    public static int MaxArea(int[] height)
    {
        int maxarea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int currentArea = Math.Min(height[left], height[right]) * width;
            maxarea = Math.Max(maxarea, currentArea);
            if (height[left] <= height[right])
                left++;
            else
                right--;
        }
        return maxarea;
    }
}
