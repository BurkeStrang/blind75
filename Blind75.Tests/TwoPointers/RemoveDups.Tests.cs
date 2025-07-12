namespace Blind75.Tests.TwoPointers;

public class RemoveDupsTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 1, 2];
        int expected = 2;
        int[] expectedArray = [1, 2];
        int result = RemoveDups.RemoveDuplicates(nums);
        result.ShouldBe(expected);
        nums.Take(expected).ToArray().ShouldBeEquivalentTo(expectedArray);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int expected = 5;
        int[] expectedArray = [0, 1, 2, 3, 4];
        int result = RemoveDups.RemoveDuplicates(nums);
        result.ShouldBe(expected);
        nums.Take(expected).ToArray().ShouldBeEquivalentTo(expectedArray);
    }

    [Fact]
    public void Example3()
    {
        int[] nums = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1];
        int expected = 1;
        int[] expectedArray = [1];
        int result = RemoveDups.RemoveDuplicates(nums);
        result.ShouldBe(expected);
        nums.Take(expected).ToArray().ShouldBeEquivalentTo(expectedArray);
    }

    [Fact]
    public void Example4()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int expected = 10;
        int[] expectedArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int result = RemoveDups.RemoveDuplicates(nums);
        result.ShouldBe(expected);
        nums.Take(expected).ToArray().ShouldBeEquivalentTo(expectedArray);
    }
}
