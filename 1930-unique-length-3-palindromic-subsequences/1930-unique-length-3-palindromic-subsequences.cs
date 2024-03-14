public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var dictionary = new Dictionary<char, HashSet<char>>(); // main / mid
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (!dictionary.ContainsKey(s[i]))
            {
                dictionary.Add(s[i], new HashSet<char>());
                for (int k = s.Length - 1; k > i + 1; k--)
                {
                    if (s[i] == s[k])
                    {
                        for (int j = i + 1; j < k; j++)
                        {
                            dictionary[s[i]].Add(s[j]);
                        }
                        break;
                    }
                }
            }
        }

        int amount = 0;
        foreach (char c in dictionary.Keys)
        {
            foreach (char x in dictionary[c])
            {
                amount++;
            }
        }
        return amount;
    }
}