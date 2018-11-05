public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> expected = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            char current = s[i];
            if (current == '(')
                expected.Push(')');
            else if (current == '[')
                expected.Push(']');
            else if (current == '{')
                expected.Push('}');
            else
            {
                if (expected.Count == 0) return false;
                char exp = expected.Pop();
                if (current != exp)
                    return false;
            }
        }
        return expected.Count == 0;
    }
}
