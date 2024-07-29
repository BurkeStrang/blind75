namespace Blind75.Tests.ArraysAndHashing;

public class SubarraySumEqualsKTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 1, 1];
        int k = 2;
        int expected = 2;
        int actual = SubarraySumEqualsK.SubarraySum(nums, k);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Example2()
    {
        int[] nums = [1, 2, 3];
        int k = 3;
        int expected = 2;
        int actual = SubarraySumEqualsK.SubarraySum(nums, k);
        actual.Should().Be(expected);
    }
}
