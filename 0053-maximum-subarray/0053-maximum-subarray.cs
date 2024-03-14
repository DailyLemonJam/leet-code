public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int localMax = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            localMax = Math.Max(nums[i], nums[i] + localMax);
            if (localMax > max) max = localMax;
        }

        return max;
    }
}