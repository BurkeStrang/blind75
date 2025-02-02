namespace Blind75.Tests.BinarySearch;

public class SingleElementInSortedArrayTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 1, 2, 3, 3, 4, 4, 8, 8];
        int expected = 2;
        int actual = SingleElementInSortedArray.SingleNonDuplicate(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [3, 7, 7, 10, 10, 11, 11];
        int expected = 3;
        int actual = SingleElementInSortedArray.SingleNonDuplicate(nums);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        int[] nums = [3, 3, 7, 7, 10, 10, 11];
        int expected = 11;
        int actual = SingleElementInSortedArray.SingleNonDuplicate(nums);
        Assert.Equal(expected, actual);
    }
}

