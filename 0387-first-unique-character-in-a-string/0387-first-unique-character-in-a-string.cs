public class Solution
{
    public int FirstUniqChar(string s)
    {
        var map = new Dictionary<char, int>();
        int result = -1;

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.TryAdd(s[i], 1))
            {
                map[s[i]]++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (map[s[i]] == 1) return i;
        }

        return result;
    }
}