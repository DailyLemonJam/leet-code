public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        int max = 1;
        int counter = 1;
        var set = new HashSet<char>();
        for (int i = 0; i < s.Length - 1; i++)
        {
            set.Add(s[i]);
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] != s[j] && !set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    counter++;
                }
                else
                {
                    set.Clear();
                    if (counter > max) max = counter;
                    counter = 1;
                    break;
                }
            }
        }
        if (counter > max) return counter;
        return max;
    }
}