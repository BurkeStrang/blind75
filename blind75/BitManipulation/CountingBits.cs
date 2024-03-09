/*
Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n),
ans[i] is the number of 1's in the binary representation of i.


Example:

Input: n = 2
Output: [0,1,1]
Explanation:
0 -> 0
1 -> 1
2 -> 10

*/
namespace blind75.BitManipulation;

public static class CountingBits
{
    public static int[] CountBits(int n)
    {
        int[] hammingWeights = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            string binary = Convert.ToString(i, 2);
            int hammingWeight = 0;
            for (int j = 0; j < binary.Length; j++)
            {
                hammingWeight += binary[j] - '0';
            }
            hammingWeights[i] = hammingWeight;
        }
        return hammingWeights;
    }
}
