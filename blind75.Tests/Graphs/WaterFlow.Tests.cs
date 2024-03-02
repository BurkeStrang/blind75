
// Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
// Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]

public class WaterFlow
{
    public void PacificAtlanticCorrect()
    {
        int[][] heights = new int[5][];
        heights[0] = new int[] { 1, 2, 2, 3, 5 };
        heights[1] = new int[] { 3, 2, 3, 4, 4 };
        heights[2] = new int[] { 2, 4, 5, 3, 1 };
        heights[3] = new int[] { 6, 7, 1, 4, 5 };
        heights[4] = new int[] { 5, 1, 1, 2, 4 };

        int[][] exp = new int[7][];
        exp[0] = new int[] { 0, 4 };
        exp[1] = new int[] { 1, 3 };
        exp[2] = new int[] { 1, 4 };
        exp[3] = new int[] { 2, 2 };
        exp[4] = new int[] { 3, 0 };
        exp[5] = new int[] { 3, 1 };
        exp[6] = new int[] { 4, 0 };

        Assert.Equal(exp, WaterFlowClass.PacificAtlantic(heights));
    }
}
