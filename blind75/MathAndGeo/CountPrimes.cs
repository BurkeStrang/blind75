namespace blind75.MathAndGeo;

public static class CountPrimesClass
{
    public static int CountPrimes(int n)
    {
        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
                count++;
        }
        return count;
    }

    public static bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        if (n < 4)
            return true;
        if (n % 2 == 0)
            return false;
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
