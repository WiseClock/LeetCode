public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x < 10)
            return true;
        if (x == -2147483648)
            return false;

        int outValue = 0;
        int scale = 1;
        do
        {
            if (scale == 1000000000)
            {
                if (outValue >= 214748364)
                    return false;
                int num = x / scale;
                outValue *= 10;
                outValue += num;
                break;
            }
            scale *= 10;
            int remainder = x % scale;
            outValue *= 10;
            outValue += remainder / (scale / 10);
        }
        while (scale <= x);
        
        return x == outValue;
    }
}
