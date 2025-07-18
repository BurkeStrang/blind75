/*
Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits
it has (also known as the Hamming weight).

Input: n = 00000000000000000000000000001011
Output: 3
Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
*/
namespace Blind75.BitManipulation;

public static class NumberOfOneBits
{
    public static int HammingWeight(uint n)
        => Convert.ToString(n, 2).Count(c => c == '1');
    // string binary = Convert.ToString(n, 2);
    // int hammingWeight = 0;
    // for (int i = 0; i < binary.Length; i++)
    // {
    //     hammingWeight += binary[i] - '0';
    // }
    // return hammingWeight;

    public static int AlterNateHammingWeight(uint n)
    {
        int hammingWeight = 0;
        while (n > 0)
        {
            // if the last bit of n is 1
            hammingWeight += (int)(n & 1);
            // shift n to the right
            n >>= 1;
        }
        return hammingWeight;
    }
}
