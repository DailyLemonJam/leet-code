public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var result = new List<IList<int>>();
        var d = new Dictionary<int, int>(); // value - amount

        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.TryAdd(nums[i], 1)) d[nums[i]]++;
        }

        while (true)
        {
            var newArr = new List<int>();

            foreach (var pair in d)
            {
                if (pair.Value > 0)
                {
                    newArr.Add(pair.Key);
                    d[pair.Key]--;
                }
            }

            if (newArr.Count == 0) break;
            result.Add(newArr);
        }

        return result;
    }
}