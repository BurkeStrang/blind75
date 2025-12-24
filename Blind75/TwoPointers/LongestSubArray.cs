namespace Blind75.TwoPointers;

public static class LongestSubArray
{
    public static List<int> GetLongestSubarray(int[] array, int k)
    {
        int left = 0;
        int sum = 0;

        int bestStart = 0;
        int bestLength = 0;

        for (int right = 0; right < array.Length; right++)
        {
            sum += array[right];

            while (sum > k && left <= right)
            {
                sum -= array[left];
                left++;
            }

            if (sum == k)
            {
                int length = right - left + 1;
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = left;
                }
            }
        }

        List<int> result = [];
        for (int i = bestStart; i < bestStart + bestLength; i++)
            result.Add(array[i]);

        return result;
    }
}
