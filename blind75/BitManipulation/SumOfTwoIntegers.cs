namespace blind75.BitManipulation;

/*

Given two integers a and b,
return the sum of the two integers without
using the operators + and -.

Example:

Input: a = 1, b = 2
Output: 3

*/

public static class SumOfTwoIntegers
{
    public static int GetSum(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b;
            a ^= b;
            b = carry << 1;
        }
        return a;
    }
}
