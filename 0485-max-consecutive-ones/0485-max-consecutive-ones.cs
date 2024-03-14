public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int currentMax = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1) currentMax++;
            else
            {
                if (currentMax > max) max = currentMax;
                currentMax = 0;
            }
        }
        
        return max > currentMax ? max : currentMax;
    }
}