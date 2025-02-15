namespace Blind75.MathAndGeo;

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


        for (int i = 3; i <= Sqrt(n); i += 2)
        {

            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static int CountPrimesSieve(int n)
    {
        if (n <= 2)
            return 0;

        int result = 0;
        bool[] sieve = new bool[n];

        for (int i = 2; i < n; i++)
        {
            if (sieve[i])
                continue;
            result++;

            for (int multiple = i * 2; multiple < n; multiple += i)
            {
                sieve[multiple] = true;
            }
        }
        return result;
    }
}
