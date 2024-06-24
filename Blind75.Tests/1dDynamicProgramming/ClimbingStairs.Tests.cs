namespace Blind75.DynammicProgramming;
// Input: n = 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step

public class ClimbingStairsTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    public void TestClimbingStairs(int n, int expected)
    {
        int result = ClimbingStairs.ClimbStairs(n);
        Assert.Equal(expected, result);
    }
}
