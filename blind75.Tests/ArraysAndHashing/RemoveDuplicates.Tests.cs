namespace Blind75.ArraysAndHashing;

public class RemoveDuplicatesTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 1, 2];
        int expected = 2;
        int result = RemoveDuplicates.RemoveDuplicatesMethod(nums);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example2()
    {
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int expected = 5;
        int result = RemoveDuplicates.RemoveDuplicatesMethod(nums);
        Assert.Equal(expected, result);
    }
}
