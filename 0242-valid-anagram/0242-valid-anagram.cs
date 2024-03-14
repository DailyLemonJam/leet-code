public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.TryAdd(s[i], 1)) map[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (map.ContainsKey(t[i]))
            {
                map[t[i]]--;
                if (map[t[i]] < 0) return false;
            }
            else return false;
        }

        return true;
    }
}