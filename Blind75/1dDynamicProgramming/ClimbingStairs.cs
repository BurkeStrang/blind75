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
        int one = 1;
        int two = 1;

        // predecrement operator
        // will decrement n before using it
        // so if n = 2, the loop will run only once
        // and if n = 3, the loop will run twice
        while (--n > 0)
        {
            // one is the number of ways to reach the current step
            // two is the number of ways to reach the previous step
            int temp = one;
            one += two;
            two = temp;
        }

        return one;
    }
}


