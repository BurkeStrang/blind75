namespace blind75.ArraysAndHashing;

public static class IsSubArrayTest
{
    [Fact]
    public static void IsSubArrayTrue()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 2];

        Assert.True(IsSubArray.IsSubArraySegment(mainArray, subArray));

    }

    [Fact]
    public static void IsSubArrayFalse()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 3];
        Assert.False(IsSubArray.IsSubArraySegment(mainArray, subArray));
    }

    [Fact]
    public static void IsSubArrayTrueLongArray()
    {
        int[] mainArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] subArray = [4, 5, 6];
        Assert.True(IsSubArray.IsSubArraySegment(mainArray, subArray));
    }

    [Fact]
    public static void IsSubArrayTrueTwoPointer()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 2];
        Assert.True(IsSubArray.IsSubArrayTwoPointer(mainArray, subArray));
    }
    [Fact]
    public static void IsSubArrayFalseTwoPointer()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 3];
        Assert.False(IsSubArray.IsSubArrayTwoPointer(mainArray, subArray));
    }
}
