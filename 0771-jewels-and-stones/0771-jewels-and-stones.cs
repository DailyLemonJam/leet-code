public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var set = new HashSet<char>();
        int result = 0;

        for (int i = 0; i < jewels.Length; i++)
        {
            set.Add(jewels[i]);
        }

        for (int i = 0; i < stones.Length; i++)
        {
            if (set.Contains(stones[i])) result++;
        }

        return result;
    }
}