public class Solution {
    public void SortColors(int[] nums) {
        for (int colorID = 0; colorID < 3; colorID++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != colorID)
                {
                    for (int k = j; k < nums.Length; k++)
                    {
                        if (k != j && nums[k] < nums[j])
                        {
                            (nums[k], nums[j]) = (nums[j], nums[k]);
                        }
                    }
                }
            }
        }
    }
}