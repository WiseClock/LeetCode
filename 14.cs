public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        if (strs.Length == 1)
            return strs[0];
        string common = "";
        int minLength = 9999;
        for (int i = 0; i < minLength; ++i)
        {
            char tmp = '0';
            for (int j = 0; j < strs.Length; ++j)
            {
                if (i == 0)
                {
                    if (strs[j].Length == 0)
                        return "";
                    if (strs[j].Length < minLength)
                        minLength = strs[j].Length;
                }
                if (tmp == '0')
                    tmp = strs[j][i];
                else if (strs[j][i] != tmp)
                    return common;
            }
            common += tmp;
            if (minLength == 1)
                break;
        }
        return common;
    }
}
