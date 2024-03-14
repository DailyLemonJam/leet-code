public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 0;
            while (nums[i] > 0)
            {
                counter++;
                nums[i] /= 10;
            }
            if (counter % 2 == 0) res++;
        }

        return res;
    }
}