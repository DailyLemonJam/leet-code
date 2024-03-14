public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int curMax = 0;
        int max;

        for (int i = 0; i < k; i++)
        {
            curMax += nums[i];
        }

        max = curMax;

        for (int i = k, j = 0; i < nums.Length; i++, j++)
        {
            curMax += nums[i] - nums[j];
            if (curMax > max) max = curMax;
        }

        return (double)max / k;
    }
}