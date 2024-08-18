namespace Blind75.ArraysAndHashing;

// Given an integer numRows, return the first numRows of Pascal's triangle.
// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
//
// Example 1:
// Input: numRows = 5
// Output: [
//              [1],
//             [1,1],
//            [1,2,1],
//           [1,3,3,1],
//          [1,4,6,4,1]
//                          ]
//
// Example 2:
// Input: numRows = 1
// Output: [[1]]
//
// Constraints:
// 1 <= numRows <= 30

public static class PascalTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = [];
        if (numRows == 0)
            return triangle;
        triangle.Add([1]);
        for (int i = 1; i < numRows; i++)
        {
            IList<int> row = [];
            IList<int> prevRow = triangle[i - 1];
            row.Add(1);
            for (int j = 1; j < i; j++)
            {
                row.Add(prevRow[j - 1] + prevRow[j]);
            }
            row.Add(1);
            triangle.Add(row);
        }
        return triangle;
    }
}
