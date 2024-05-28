namespace Blind75.Greedy;

public class MergeTripletsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] triplets =
        [
            [2, 5, 3],
            [1, 8, 4],
            [1, 7, 5]
        ];
        int[] target = [2, 7, 5];
        bool expected = true;
        // Act
        bool actual = MergeTripletsClass.MergeTriplets(triplets, target);
        // Assert
        Assert.Equal(expected, actual);

    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] triplets =
        [
            [3, 4, 5],
            [4, 5, 6]
        ];
        int[] target = [3, 2, 5];
        bool expected = false;
        // Act
        bool actual = MergeTripletsClass.MergeTriplets(triplets, target);
        // Assert
        Assert.Equal(expected, actual);
    }

}
