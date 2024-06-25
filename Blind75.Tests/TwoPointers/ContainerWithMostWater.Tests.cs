namespace Blind75.Tests.TwoPointers;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void ContainerWithMostWaterReturnsValidAnswer()
    {
        int[] nums = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int maxArea = 49;
        Assert.Equal(maxArea, ContainerWithMostWaterClass.MaxArea(nums));
    }

    [Fact]
    public void ContainerWithMostWaterReturnsValidAnswer2()
    {
        int[] nums = [1, 1];
        int maxArea = 1;
        Assert.Equal(maxArea, ContainerWithMostWaterClass.MaxArea(nums));
    }
    [Fact]
    public void ContainerWithMostWaterReturnsValidAnswer3()
    {
        int[] nums = [4, 3, 2, 1, 4];
        int maxArea = 16;
        Assert.Equal(maxArea, ContainerWithMostWaterClass.MaxArea(nums));
    }
}
