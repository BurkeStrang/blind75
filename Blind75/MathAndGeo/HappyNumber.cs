namespace Blind75.MathAndGeo;

/*

Write an algorithm to determine if a number n is happy.
A happy number is a number defined by the following process:
Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay),
or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

Example 1:
Input: n = 19
Output: true
Explanation:
1 + 81 = 82
64 + 4 = 68
36 + 64 = 100
1 + 0 + 0 = 1

Example 2:
Input: n = 2
Explanation:
4
16
1 + 36 = 37
9 + 49 = 58
25 + 81 = 106
1 + 0 + 36 = 37
detect cycle
Output: false
 

Constraints:
1 <= n <= 231 - 1

*/

public static class HappyNumber
{
    public static bool IsHappy(int n)
    {
        HashSet<int> seenNumbers = [];
        while (!seenNumbers.Contains(n))
        {
            seenNumbers.Add(n);
            n = CalculateSumOfSquares(n);

            if (n == 1)
                return true;
        }
        return false;
    }

    private static int CalculateSumOfSquares(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit * digit;
            number /= 10;
        }
        return sum;
    }
}
