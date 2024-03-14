public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;

        var res = new List<int>();
        var set = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            set.Add(nums[i]);
        }

        for (int i = 1; i <= n; i++)
        {
            if (!set.Contains(i))
            {
                res.Add(i);
            }
        }

        return res;
    }
}