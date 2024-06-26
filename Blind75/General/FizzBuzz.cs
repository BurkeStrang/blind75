namespace Blind75.General;

public static class FizzBuzz
{
    public static string PrintFizzBuzz(int n)
    {
        StringBuilder output = new();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                output.AppendLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                output.AppendLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                output.AppendLine("Buzz");
            }
            else
            {
                output.AppendLine(i.ToString());
            }
        }
        return output.ToString();
    }

    public static IEnumerable<string> FizzBuzzLinq(int n)
    {
        return Enumerable
            .Range(1, n)
            .Select(i =>
                (i % 3, i % 5) switch
                {
                    (0, 0) => "FizzBuzz",
                    (0, _) => "Fizz",
                    (_, 0) => "Buzz",
                    _ => i.ToString()
                }
            );
    }
}
