namespace Blind75.BitManipulation;

/*

Given a signed 32-bit integer x, return x with its digits reversed.
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:
Input: x = 123
Output: 321

Example 2:
Input: x = -123
Output: -321

Example 3:
Input: x = 120
Output: 21

Constraints:
-231 <= x <= 231 - 1

*/

public class ReverseIntegers
{
    public static int Reverse(int x)
    {
        int rev = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;
            if (
                rev > int.MaxValue / 10
                ||
                // since max value is 2,147,483,647,
                // last digit greater than 7 will overflow
                (rev == int.MaxValue / 10 && digit > 7)
            )
                return 0;

            if (
                rev < int.MinValue / 10
                ||
                // since min value is  -2,147,483,648
                (rev == int.MinValue / 10 && digit < -8)
            )
                return 0;

            rev = rev * 10 + digit;
        }

        return rev;
    }
}
