public class Solution
{
    public int RomanToInt(string s)
    {
        int val = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            int cv = GetInt(c);
            char nc = i + 1 >= s.Length ? 'Z' : s[i + 1];
            if ((c == 'I' && (nc == 'V' || nc == 'X')) || (c == 'X' && (nc == 'L' || nc == 'C')) || (c == 'C' && (nc == 'D' || nc == 'M')))
            {
                cv *= -1;
                val += GetInt(nc);
                i++;
            }
            val += cv;
        }
        return val;
    }
    public int GetInt(char c)
    {
        int cv = 1;
        if (c == 'V') cv = 5;
        else if (c == 'X') cv = 10;
        else if (c == 'L') cv = 50;
        else if (c == 'C') cv = 100;
        else if (c == 'D') cv = 500;
        else if (c == 'M') cv = 1000;
        return cv;
    }
}
