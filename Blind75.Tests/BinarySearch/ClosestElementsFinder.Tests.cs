namespace Blind75.Tests.BinarySearch;
public class ClosestElementsFinderTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int k = 4;
        int target = 3;
        List<int> expected = [1, 2, 3, 4];
        List<int> actual = ClosestElementsFinder.FindClosestElements(nums, k, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [0, 1, 1, 1, 2, 3, 6, 7, 8, 9];
        int k = 9;
        int target = 4;
        List<int> expected = [0, 1, 1, 1, 2, 3, 6, 7, 8];
        List<int> actual = ClosestElementsFinder.FindClosestElements(nums, k, target);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int k = 4;
        int target = 6;
        List<int> expected = [2, 3, 4, 5];
        List<int> actual = ClosestElementsFinder.FindClosestElements(nums, k, target);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example4()
    {
        int[] nums = [1, 1, 1, 10, 10, 10];
        int k = 1;
        int target = 9;
        List<int> expected = [10];
        List<int> actual = ClosestElementsFinder.FindClosestElements(nums, k, target);
        Assert.Equal(expected, actual);
    }

}

