public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int max = 0;
        int sum;
        for (int i = 0; i < nums.Length / 2; i++)
        {
            sum = nums[i] + nums[nums.Length - 1 - i];
            if (sum > max)
            {
                max = sum;
            }
        }
        return max;
    }
}