public class Solution
{
    public int Reverse(int x)
    {
        if (x == -2147483648)
            return 0;
        bool negative = x < 0;
        x = negative ? -x : x;
        int outValue = 0;
        int scale = 1;
        do
        {
            if (scale == 1000000000)
            {
                int num = x / scale;
                if (outValue > 214748364 || (outValue == 214748364 && num >= 7))
                    return 0;
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
        return negative ? -outValue : outValue;
    }
}
