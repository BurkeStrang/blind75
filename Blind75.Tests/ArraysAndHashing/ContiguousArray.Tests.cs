namespace Blind75.Tests.ArraysAndHashing;

public class ContiguousArrayTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [0, 1];
        int expected = 2;
        int actual = ContiguousArray.FindMaxLength(nums);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [0, 1, 0];
        int expected = 2;
        int actual = ContiguousArray.FindMaxLength(nums);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Example3()
    {
        int[] nums = [0, 1, 1, 0, 1, 1, 1, 0];
        int expected = 4;
        int actual = ContiguousArray.FindMaxLength(nums);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Example4()
    {
        int[] nums = [0, 0, 1, 0, 0, 0, 1, 1];
        int expected = 6;
        int actual = ContiguousArray.FindMaxLength(nums);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Example5()
    {
        int[] nums = [0, 1, 0, 1];
        int expected = 4;
        int actual = ContiguousArray.FindMaxLength(nums);
        actual.ShouldBe(expected);
    }
}
