namespace Blind75.Tests.TwoPointers;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void ContainerWithMostWaterReturnsValidAnswer()
    {
        int[] nums = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int maxHeight = 49;
        Assert.Equal(maxHeight, ContainerWithMostWaterClass.MaxArea(nums));
    }

    [Fact]
    public void ContainerWithMostWaterReturnsValidAnswer2()
    {
        int[] nums = [1, 1];
        int maxHeight = 1;
        Assert.Equal(maxHeight, ContainerWithMostWaterClass.MaxArea(nums));
    }
}
