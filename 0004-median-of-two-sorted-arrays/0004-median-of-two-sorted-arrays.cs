public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merged = new List<int>();
        var n1 = new List<int>(nums1);
        var n2 = new List<int>(nums2);

        while (n1.Count != 0 && n2.Count != 0)
        {
            if (n1[0] > n2[0])
            {
                merged.Add(n2[0]);
                n2.RemoveAt(0);
            }
            else if (n1[0] < n2[0])
            {
                merged.Add(n1[0]);
                n1.RemoveAt(0);
            }
            else
            {
                merged.Add(n1[0]);
                merged.Add(n2[0]);
                n1.RemoveAt(0);
                n2.RemoveAt(0);
            }
        }

        merged.AddRange(n1);
        merged.AddRange(n2);
        
        if (merged.Count % 2 == 1) return merged[merged.Count / 2];
        return (double)(merged[merged.Count / 2 - 1] + merged[merged.Count / 2]) / 2;
    }
}