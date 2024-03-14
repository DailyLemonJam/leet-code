public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];
        var d = new Dictionary<int, int>(); // number - freq

        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.TryAdd(nums[i], 1)) d[nums[i]]++;
        }

        d = d.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        int j = 0;
        foreach (int key in d.Keys)
        {
            result[j] = key;
            j++;
            if (j == k) break;
        }

        return result;
    }
}