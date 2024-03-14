public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums2.Contains(nums1[i]) && !result.Contains(nums1[i]))
            {
                result.Add(nums1[i]);
            }
        }

        return result.ToArray();
    }
}