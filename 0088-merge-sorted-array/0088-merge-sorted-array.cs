public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        nums2.CopyTo(nums1, m);
        Array.Sort(nums1);
    }
}