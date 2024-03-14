public class Solution
{
    public int MinOperations(int[] nums)
    {
        var d = new Dictionary<int, int>(); // value - amount
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(nums[i])) d[nums[i]]++;
            else d.Add(nums[i], 1);
        }

        foreach (var pair in d)
        {
            if (pair.Value == 1) return -1;
            else if (pair.Value % 3 == 0) result += pair.Value / 3;
            else if (pair.Value % 3 == 1) result += ((pair.Value - 1) / 3) + 1;
            else result += (pair.Value / 3) + 1;
        }

        return result;
    }
}