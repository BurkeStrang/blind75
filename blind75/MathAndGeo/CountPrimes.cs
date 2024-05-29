namespace Blind75.MathAndGeo;

//e.g. CountPrimesClass.CountPrimes(10) => 4

public static class CountPrimesClass
{
    public static int CountPrimes(int n)
    {
        int count = 0;
        // 0 and 1 are not prime
        // so we start at 2
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
                count++;
        }
        return count;
    }

    public static bool IsPrime(int n)
    {
        // 0 and 1 are not prime
        if (n < 2)
            return false;
        // 2 and 3 are prime
        if (n < 4)
            return true;
        // all other even numbers are not prime
        if (n % 2 == 0)
            return false;
        // if n is not a prime, it can be factored into two factors a and b: n = a * b
        // this is the same as a = b = sqrt(n)
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            // if n is divisible by any number between 3 and sqrt(n), it is not prime
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
