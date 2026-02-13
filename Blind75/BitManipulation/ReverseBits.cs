namespace Blind75.BitManipulation;

public static class ReverseBitsClass
{
    public static uint ReverseBits(uint n)
    {

        // WriteLine("----------------------------------------");
        // WriteLine($"n: {n}");
        // WriteLine($"n = {Convert.ToString(n, 2).PadLeft(32, '0')}");
        uint result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;   // make room on the right
            // WriteLine($"After shift:  result = {Convert.ToString(result, 2).PadLeft(33, '0')}, n = {Convert.ToString(n, 2).PadLeft(32, '0')}");
            result |= n & 1;// copy lowest bit of n
            // WriteLine($"After OR:     result = {Convert.ToString(result, 2).PadLeft(33, '0')}, n = {Convert.ToString(n, 2).PadLeft(32, '0')}");
            n >>= 1;        // drop the bit we just used
            // WriteLine($"After n>>=1:  result = {Convert.ToString(result, 2).PadLeft(32, '0')}, n = {Convert.ToString(n, 2).PadLeft(32, '0')}");
        }

        return result;
    }
}
