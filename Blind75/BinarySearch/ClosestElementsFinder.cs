namespace Blind75.BinarySearch;

public class ClosestElementsFinder
{
    /// <summary>
    /// Finds the k closests elements to the target.
    /// </summary>
    /// <param name="nums">The sorted array of integers.</param>
    /// <param name="k">The number of elements to return.</param>
    /// <param name="target">The target value.</param>
    /// <returns>The k closest elements to the target.</returns>
    /// <example>
    ///     nums = [1,1,1,10,10,10], k = 1, target = 9
    ///     output: [10]
    /// </example>
    public static List<int> FindClosestElements(ReadOnlySpan<int> nums, int k, int target)
    {
        if (nums.Length == k)
            return [.. nums];

        if (target <= nums[0])
            return [.. nums[..k]];

        if (target >= nums[^1])
            return [.. nums[(nums.Length - k)..]];

        int index = nums.BinarySearch(target);
        if (index < 0)
            index = ~index;

        int left = index - 1;
        int right = index;

        while (right - left - 1 < k)
        {
            if (left < 0)
                right++;
            else if (right >= nums.Length)
                left--;
            else if (target - nums[left] <= nums[right] - target)
                left--;
            else
                right++;
        }
        return [.. nums[(left + 1)..right]];
    }

    public static IList<int> FindClosestElementsFast(ReadOnlySpan<int> nums, int k, int target)
    {
        int low = 0, high = nums.Length - k;
        while (low < high)
        {
            int mid = low + ((high - low) >> 1);
            if (target - nums[mid] > nums[mid + k] - target)
                low = mid + 1;
            else
                high = mid;
        }
        return nums.Slice(low, k).ToArray().ToList();
    }
}
