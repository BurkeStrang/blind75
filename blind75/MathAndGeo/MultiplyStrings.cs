namespace Blind75.MathAndGeo;

/*

Given two non-negative integers num1 and num2 represented as strings,
return the product of num1 and num2, also represented as a string.
Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.

Example 1:
Input: num1 = "2", num2 = "3"
Output: "6"

Example 2:
Input: num1 = "123", num2 = "456"
Output: "56088"

Constraints:
1 <= num1.length, num2.length <= 200
num1 and num2 consist of digits only.
Both num1 and num2 do not contain any leading zero, except the number 0 itself.

*/

public static class MultiplyStrings
{
    // Time Complexity: O(m*n)  | Space Complexity: O(m+n)
    public static string Multiply(string num1, string num2)
    {
        // Handle multiplication by zero
        if (num1 == "0" || num2 == "0")
            return "0";

        // Array to store the multiplication result
        int[] result = new int[num1.Length + num2.Length];

        // Reverse the input strings
        num1 = Reverse(num1);
        num2 = Reverse(num2);

        // Perform multiplication digit by digit
        for (int i = 0; i < num1.Length; i++)
        {
            for (int j = 0; j < num2.Length; j++)
            {
                int digit1 = num1[i] - '0';
                int digit2 = num2[j] - '0';
                int product = digit1 * digit2;

                result[i + j] += product;
                result[i + j + 1] += result[i + j] / 10;
                result[i + j] %= 10;
            }
        }

        // Convert result array to a string
        return ConvertResultArrayToString(result);
    }

    private static string Reverse(string str)
        => new([.. str.Reverse()]);

    private static string ConvertResultArrayToString(int[] result)
    {
        // Remove leading zeros
        int startIndex = result.Length - 1;
        while (startIndex >= 0 && result[startIndex] == 0)
        {
            startIndex--;
        }

        // Build the result string
        StringBuilder str = new();
        for (int i = startIndex; i >= 0; i--)
        {
            str.Append(result[i]);
        }

        return str.Length == 0 ? "0" : $"{str}";
    }
}
