public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length;
        int mid = (r + l) / 2;

        while (l < r)
        {
            if (nums[mid] == target) return mid;

            if (nums[mid] > target) r = mid;
            else l = mid + 1;

            mid = (r + l) / 2;
        }

        return -1;
    }
}