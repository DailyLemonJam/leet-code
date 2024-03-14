public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var map1 = new Dictionary<int, int>();

        var result = new List<int>();

        foreach (int x in nums1)
        {
            if (!map1.TryAdd(x, 1)) map1[x]++;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (map1.ContainsKey(nums2[i]))
            {
                if (map1[nums2[i]] > 0)
                {
                    result.Add(nums2[i]);
                    map1[nums2[i]]--;
                }
            }
        }
        
        return result.ToArray();
    }
}