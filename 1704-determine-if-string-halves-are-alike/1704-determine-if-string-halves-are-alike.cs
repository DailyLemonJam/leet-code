public class Solution
{
    public bool HalvesAreAlike(string s)
    {
        HashSet<char> set = new()
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U',
        };
        int c1 = 0, c2 = 0;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (set.Contains(s[i])) c1++;
            if (set.Contains(s[i + s.Length / 2])) c2++;
        }

        return c1 == c2;
    }
}