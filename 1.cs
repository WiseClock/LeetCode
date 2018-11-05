public class Solution
{
    private Dictionary<int, int> _lookingFor = new Dictionary<int, int>();
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            int n = nums[i];
            if (_lookingFor.TryGetValue(n, out int index))
                return new int[] { index, i };
            int lf = target - n;
            if (!_lookingFor.ContainsKey(lf))
                _lookingFor[lf] = i;
        }
        return new int[] {};
    }
}
