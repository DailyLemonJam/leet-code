public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var res = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
        {
            res.Add(true);
            for (int j = 0; j < candies.Length; j++)
            {
                if (i != j && candies[i] + extraCandies < candies[j])
                {
                    res.RemoveAt(res.Count - 1);
                    res.Add(false);
                }
            }
        }

        return res;
    }
}