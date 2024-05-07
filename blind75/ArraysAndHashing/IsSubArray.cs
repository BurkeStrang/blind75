namespace Blind75.ArraysAndHashing;

public static class IsSubArray
{
    public static bool IsSubArraySegment(int[] mainArray, int[] subArray)
    {
        int front = 0;
        int subLength = subArray.Length;
        while (front + subLength < mainArray.Length)
        {
            ArraySegment<int> segment = new(mainArray, front, subLength);
            if (subArray.SequenceEqual(segment))
                return true;
            front++;
        }
        return false;
    }

    public static bool IsSubArrayTwoPointer(int[] mainArray, int[] subArray)
    {
        // Two pointers to traverse the arrays
        int i = 0, j = 0;

        // Traverse both arrays simultaneously
        while (i < mainArray.Length && j < subArray.Length)
        {

            // If element matches
            // increment both pointers
            if (mainArray[i] == subArray[j])
            {

                i++;
                j++;

                // If array B is completely
                // traversed
                if (j == subArray.Length)
                    return true;
            }
            // If not,
            // increment i and reset j
            else
            {
                i = i - j + 1;
                j = 0;
            }
        }

        return false;

    }
}
