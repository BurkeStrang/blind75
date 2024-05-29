namespace Blind75.MathAndGeo;

/*

Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

Example 1:
Input: x = 2.00000, n = 10
Output: 1024.00000

Example 2:
Input: x = 2.10000, n = 3
Output: 9.26100

Example 3:
Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25

Constraints:
-100.0 < x < 100.0
-231 <= n <= 231-1
n is an integer.
Either x is not zero or n > 0.
-104 <= xn <= 104

*/

public static class Pow
{
    public static double MyPow(double x, long n)
    {
        // C# Implementation
        // Math.Pow(x, n);
        double result = Helper(x, Math.Abs(n));
        return n > 0 ? result : 1 / result;
    }

    private static double Helper(double x, long n)
    {
        if (x == 0)
            return 0;
        if (n == 0)
            return 1;

        double result = Helper(x, n / 2);
        result *= result;
        return n % 2 == 1 ? x * result : result;
    }
}
