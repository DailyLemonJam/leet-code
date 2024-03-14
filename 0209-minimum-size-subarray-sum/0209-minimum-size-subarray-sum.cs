public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int l = 0, sum = 0;
        int min = int.MaxValue;

        for (int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            while (sum >= target)
            {
                if (r - l + 1 < min) min = r - l + 1;
                sum -= nums[l];
                l++;
            }
        }

        return min == int.MaxValue ? 0 : min;
    }
}