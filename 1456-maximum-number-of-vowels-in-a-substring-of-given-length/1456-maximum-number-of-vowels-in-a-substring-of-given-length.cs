public class Solution
{
    public int MaxVowels(string s, int k)
    {
        string vowels = "aeiou";

        int max = 0;

        for (int i = 0; i < k; i++)
        {
            if (vowels.Contains(s[i])) max++;
        }

        int cur = max;

        for (int i = k, j = 0; i < s.Length; i++, j++)
        {
            if (vowels.Contains(s[i])) cur++;
            if (vowels.Contains(s[j])) cur--;
            if (cur > max) max = cur;
        }

        return max;
    }
}