public class Solution
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        int result = 0;
        int currentLength;

        for (int i = 0; i < words.Length; i++)
        {
            currentLength = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == words[i][currentLength])
                {
                    currentLength++;
                    if (currentLength == words[i].Length)
                    {
                        result++;
                        break;
                    }
                }
            }
        }

        return result;
    }
}