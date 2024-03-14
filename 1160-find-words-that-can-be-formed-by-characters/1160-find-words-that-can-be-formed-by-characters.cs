public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var charsSourceDictionary = new Dictionary<char, int>();
        int res = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (!charsSourceDictionary.TryAdd(chars[i], 1))
            {
                charsSourceDictionary[chars[i]]++;
            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            var tempD = new Dictionary<char, int>(charsSourceDictionary);
            bool hasEnoughChars = true;

            for (int j = 0; j < words[i].Length; j++)
            {
                if (tempD.ContainsKey(words[i][j]))
                {
                    tempD[words[i][j]]--;
                    if (tempD[words[i][j]] < 0)
                    {
                        hasEnoughChars = false;
                        continue;
                    }
                }
                else
                {
                    hasEnoughChars = false;
                    continue;
                }
            }

            if (hasEnoughChars) res += words[i].Length;
        }

        GC.Collect();

        return res;
    }
}