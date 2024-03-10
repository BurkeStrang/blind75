namespace blind75.BitManipulation;

public static class ReverseBitsClass
{
    public static uint ReverseBits(uint n)
    {
        uint result = 0;
        // iterate through 32 bits
        for (int i = 0; i < 32; i++)
        {
            // get the last bit of n if it's last bit is 1
            uint temp = n & 1;
            // shift result to the left and add temp
            result = (result << 1) + temp;
            // shift n to the right
            n >>= 1;
        }
        return result;
    }
}
