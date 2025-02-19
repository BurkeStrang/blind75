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
        // this is the sieve
        // 0 and 1 are not prime and not included in counts
        // although they are in the array
        // set to false for all values on initialization
        bool[] notPrimes = new bool[n];

        for (int i = 2; i < n; i++)
        {
            if (notPrimes[i])
                continue;
            // will only be counted if not a multiple seen before
            result++;
            // every multiple of a prime is not prime and set to true
            for (int multiple = i + i; multiple < n; multiple += i)
            {
                notPrimes[multiple] = true;
                // notPrimes.Dump();
            }
        }
        return result;
    }
}
