public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var map = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                foreach (var index in map[nums[i]])
                {
                    if (index != i && Math.Abs(index - i) <= k) return true;
                }
            }
            
            if (!map.TryAdd(nums[i], new List<int>() { i }))
            {
                map[nums[i]].Add(i);
            }
        }

        return false;
    }
}