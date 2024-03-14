public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);

        int max = 0;

        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                int current = 0;
                while (set.Contains(n + current)) current++;
                if (current > max) max = current;
            }
        }

        return max;
    }
}