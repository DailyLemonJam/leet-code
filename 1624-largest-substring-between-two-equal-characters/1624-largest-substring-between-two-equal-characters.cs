public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var d = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            d.TryAdd(s[i], i);
        }

        int max = -1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (d.ContainsKey(s[i]))
            {
                if (i - d[s[i]] > max) max = i - d[s[i]] - 1;
            }
        }

        return max;
    }
}