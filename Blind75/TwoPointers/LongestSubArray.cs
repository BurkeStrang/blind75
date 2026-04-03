namespace Blind75.TwoPointers;

// get longest sub array that equals the sum ok k
// sub array mean it must maintain it's order in the original array
// example
// array = { 1, 2, 3, 7, 5 }
// k = 12
// output = { 2, 3, 7 }

public static class LongestSubArray
{
    public static List<int> GetLongestSubarray(int[] array, int k)
    {
        List<int> maxLength = [];

        if (array.Length == 0)
            return maxLength;

        int left = 0;
        int sum = 0;

        for (int right = 0; right < array.Length; right++)
        {
            sum += array[right];

            while (sum > k && left <= right)
            {
                sum -= array[left];
                left++;
            }

            if (sum == k && right - left + 1 > maxLength.Count)
            {
                List<int> res = [];
                for (int i = left; i <= right; i++)
                    res.Add(array[i]);
                maxLength = res;
            }
        }

        return maxLength;
    }
}
