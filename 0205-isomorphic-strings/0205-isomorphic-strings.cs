public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.TryAdd(s[i], t[i]))
            {
                if (t[i] != map[s[i]]) return false;
            }
        }

        map.Clear();

        for (int i = 0; i < t.Length; i++)
        {
            if (!map.TryAdd(t[i], s[i]))
            {
                if (s[i] != map[t[i]]) return false;
            }
        }

        return true;
    }
}