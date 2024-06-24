namespace Blind75.Tests.ArraysAndHashing;

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

    [Fact]
    public static void IsSubArrayTrueCheckEachElementInArray()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 2];
        Assert.True(IsSubArray.IsSubArrayCheckEachElementInArray(mainArray, subArray));
    }

    [Fact]
    public static void IsSubArrayFalseCheckEachElementInArray()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 3];
        Assert.False(IsSubArray.IsSubArrayCheckEachElementInArray(mainArray, subArray));
    }
    [Fact]
    public static void IsSubArrayTrueLinq()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 2];
        Assert.True(IsSubArray.IsSubArrayLinq(mainArray, subArray));
    }
    [Fact]
    public static void IsSubArrayFalseLinq()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 3];
        Assert.False(IsSubArray.IsSubArrayLinq(mainArray, subArray));
    }

    [Fact]
    public static void IsSubArrayDoubleyLinkedList()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 2];
        Assert.True(IsSubArray.IsSubArrayDoubleyLinkedList(mainArray, subArray));
    }
    [Fact]
    public static void IsSubArrayFalseDoubleyLinkedList()
    {
        int[] mainArray = [1, 2, 3, 4];
        int[] subArray = [1, 3];
        Assert.False(IsSubArray.IsSubArrayDoubleyLinkedList(mainArray, subArray));
    }
}
