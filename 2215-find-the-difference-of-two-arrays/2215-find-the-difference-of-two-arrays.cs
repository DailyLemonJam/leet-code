public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var result = new List<IList<int>>() { new List<int>(), new List<int>() };

        var set = new HashSet<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            set.Add(nums1[i]);
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (!set.Contains(nums2[i]) && !result[1].Contains(nums2[i]))
            {
                result[1].Add(nums2[i]);
            }
        }

        set.Clear();

        for (int i = 0; i < nums2.Length; i++)
        {
            set.Add(nums2[i]);
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!set.Contains(nums1[i]) && !result[0].Contains(nums1[i]))
            {
                result[0].Add(nums1[i]);
            }
        }

        return result;
    }
}