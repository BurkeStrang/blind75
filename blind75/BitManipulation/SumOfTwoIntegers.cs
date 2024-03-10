namespace blind75.BitManipulation;

/*

Given two integers a and b,
return the sum of the two integers without
using the operators + and -.

Example:

Input: a = 1, b = 2
Output: 3

Example:

Input: a = -2, b = 3
Output: 1

Explanation:
a = -0010
b = 0011
carry = 0000
a
*/

public static class SumOfTwoIntegers
{
    public static int GetSum(int a, int b)
    {
        // Iterate till there is no carry
        while (b != 0)
        {
            // carry now contains common set bits of a and b
            int carry = a & b;
            // Sum of bits of a and b where at least one of the bits is not set
            a ^= b;
            // Carry is shifted by one so that adding to it gives the required sum
            b = carry << 1;
        }
        return a;
    }
}
