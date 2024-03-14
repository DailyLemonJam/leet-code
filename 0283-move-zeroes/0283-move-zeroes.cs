public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int zeroPtr = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[zeroPtr] = nums[i];
                zeroPtr++;
            }
        }

        for (int i = zeroPtr; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}