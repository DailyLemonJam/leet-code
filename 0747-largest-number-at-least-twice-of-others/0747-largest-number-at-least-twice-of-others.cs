public class Solution
{
    public int DominantIndex(int[] nums)
    {
        int max = nums[0];
        int maxIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i] * 2 && i != maxIndex) return -1;
        }

        return maxIndex;
    }
}