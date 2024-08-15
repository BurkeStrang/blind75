namespace Blind75.ArraysAndHashing;

// Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
//
// Example 1:
// Input: rowIndex = 3
// Output: [1,3,3,1]
//
// Example 2:
// Input: rowIndex = 0
// Output: [1]
//
// Example 3:
// Input: rowIndex = 1
// Output: [1,1]
//
// Constraints:
// 0 <= rowIndex <= 33
//
// Follow up: Could you optimize your algorithm to use only O(rowIndex) extra space?

public static class PascalsTriangleII
{
    public static IList<int> GetRow(int rowIndex)
    {
        IList<int> result = [];
        for (int i = 0; i <= rowIndex; i++)
        {
            result.Add(1);
            for (int j = i - 1; j > 0; j--)
                result[j] += result[j - 1];
        }
        return result;
    }
}

