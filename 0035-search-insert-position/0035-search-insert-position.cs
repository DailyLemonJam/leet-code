public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int r = Array.BinarySearch(nums, target);
        return r >= 0 ? r : -r - 1;
    }
}