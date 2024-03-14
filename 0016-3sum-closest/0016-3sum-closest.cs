public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int res = int.MaxValue;
        int currentSum;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    currentSum = nums[i] + nums[j] + nums[k];
                    if (currentSum == target) return currentSum;
                    if (Math.Abs(target - res) > Math.Abs(target - currentSum))
                    {
                        res = currentSum;
                    }
                }
            }
        }
        return res;
    }
}