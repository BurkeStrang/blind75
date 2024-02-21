namespace blind75.ArraysAndHashing;

public static class ProductOfArrayExceptSelfClass
{
    public static int[] ProductOfArrayExceptSelf(int[] nums)
    {
        int numsLength = nums.Length;
        int prefixProduct = 1;
        int suffixProduct = 1;
        int[] result = new int[numsLength];
        for (int i = 0; i < numsLength; i++)
        {
            result[i] = prefixProduct;
            prefixProduct *= nums[i];
        }
        for (int i = numsLength - 1; i >= 0; i--)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }
        return result;
    }
}
