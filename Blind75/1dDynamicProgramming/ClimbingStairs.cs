namespace Blind75.DynammicProgramming;

// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps

// Input: n = 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step

public static class ClimbingStairs
{
    public static int ClimbStairs(int n)
    {
        int one = 1, two = 1;
        for (int i = 1; i < n; i++)
        {
            int temp = one + two;
            one = two;
            two = temp;
        }
        return two;
    }
}


