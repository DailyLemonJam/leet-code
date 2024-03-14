public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int ptrToReplace = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                (nums[ptrToReplace], nums[i]) = (nums[i], nums[ptrToReplace]);
                ptrToReplace++;
            }
        }

        return nums;
    }
}