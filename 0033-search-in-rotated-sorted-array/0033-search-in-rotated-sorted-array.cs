public class Solution {
    public int Search(int[] nums, int target) {
        return nums.ToList().IndexOf(target); // O(n), not O(log n)
    }
}