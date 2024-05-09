namespace Blind75.ArraysAndHashing;

// Given an array nums of n integers where n > 1,
// return an array output such that output[i] is
// equal to the product of all the elements of nums except nums[i].
// [1,2,3,4] => [24,12,8,6]
public static class ProductOfArrayExceptSelfClass
{
    // uses O(n) time and O(1) space
    // ueses prefix and suffix product
    public static int[] ProductOfArrayExceptSelf(int[] nums)
    {
        int numsLength = nums.Length;
        int prefixProduct = 1;
        int suffixProduct = 1;
        // the result array is not counted in the space complexity
        // as it is the output
        int[] result = new int[numsLength];
        for (int i = 0; i < numsLength; i++)
        {
            result[i] = prefixProduct;
            prefixProduct *= nums[i];
            // result = [1,1,2,6]
            // prefixProduct = 1,2,6,24
        }
        for (int i = numsLength - 1; i >= 0; i--)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
            // result = [24,12,8,6]
            // suffixProduct = 1,4,12,24
        }
        return result;
    }
}
