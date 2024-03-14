public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>
        {
            { nums[0], 0 }
        };

        for (int i = 1; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return new int[] { map[target - nums[i]], i };
            }
            map.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
