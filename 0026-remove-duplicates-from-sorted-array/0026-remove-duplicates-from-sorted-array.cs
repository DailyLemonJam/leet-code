public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int ptrToReplace = 1;

        int counter = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[ptrToReplace] = nums[i];
                ptrToReplace++;
            }
            else counter++;
        }

        return nums.Length - counter;
    }
}