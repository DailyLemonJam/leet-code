public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;

        int[] temp = new int[n - k];

        for (int i = 0; i < n - k; i++)
        {
            temp[i] = nums[i];
        }

        for (int i = n - k, j = 0; i < n; i++, j++)
        {
            nums[j] = nums[i];
        }

        for (int i = k, j = 0; i < n; i++, j++)
        {
            nums[i] = temp[j];
        }
    }
}