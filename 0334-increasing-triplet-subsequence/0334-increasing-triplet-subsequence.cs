public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3) return false;

        int smallest1 = int.MaxValue;
        int smallest2 = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= smallest1) smallest1 = nums[i];
            else if (nums[i] <= smallest2) smallest2 = nums[i];
            else return true;
        }

        return false;
    }
}