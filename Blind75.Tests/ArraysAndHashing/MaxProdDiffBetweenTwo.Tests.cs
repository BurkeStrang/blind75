namespace Blind75.Tests.ArraysAndHashing;

public class MaxProdDiffBetweenTwoTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [5, 6, 2, 7, 4];
        int expected = 34;

        int res = MaxProdDiffBetweenTwo.MaxProductDifference(nums);

        res.ShouldBe(expected);
    }
}
