// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps

public static class ClimbingStairsClass
{
    public static int ClimbStairs(int n)
    {

        var one = 1;
        var two = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int temp = one;
            one = one + two;
            two = temp;
        }

        return one;
    }
}
