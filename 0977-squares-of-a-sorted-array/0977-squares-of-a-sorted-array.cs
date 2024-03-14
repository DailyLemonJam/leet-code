public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var res = new Stack<int>();

        int l = 0;
        int r = nums.Length - 1;

        while (l != r)
        {
            if (Math.Abs(nums[l]) > Math.Abs(nums[r]))
            {
                res.Push(nums[l] * nums[l]);
                l++;
            }
            else
            {
                res.Push(nums[r] * nums[r]);
                r--;
            }
        }

        res.Push(nums[l] * nums[l]);

        Array.Reverse(res.ToArray());
        return res.ToArray();
    }
}