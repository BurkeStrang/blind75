using static System.Math;
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
        for (int i = 3; i <= Sqrt(n); i += 2)
        {
            // if n is divisible by any number between 3 and sqrt(n), it is not prime
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static int CountPrimesSieve(int n)
    {
        // If n is less than or equal to 2, there are no prime numbers less than n
        if (n <= 2)
            return 0;

        int result = 0; // Variable to count the number of prime numbers
        bool[] sieve = new bool[n]; // Boolean array to mark non-prime numbers, initialized to false

        // Iterate through each number from 2 to n-1
        for (int i = 2; i < n; i++)
        {
            // If sieve[i] is true, it means the number i has been marked as non-prime
            if (sieve[i])
                continue; // Skip the rest of the loop for this number

            // If sieve[i] is still false, it means the number i is prime
            result++; // Increment the count of prime numbers

            // Mark all multiples of i as non-prime
            for (int multiple = i * 2; multiple < n; multiple += i)
            {
                sieve[multiple] = true; // Mark the multiple of i as non-prime
            }
        }

        return result; // Return the total count of prime numbers less than n
    }
}
