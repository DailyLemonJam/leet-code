public class Solution
{
    public string LongestPalindrome(string s)
    {
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s.Length - i < endIndex - startIndex) 
                {
                    return s.Substring(startIndex, endIndex - startIndex + 1);
                }
                if (IsPalindromic(s.Substring(i, j - i + 1)))
                {
                    if (j - i > endIndex - startIndex)
                    {
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }
        }
        return s.Substring(startIndex, endIndex - startIndex + 1);
    }

    public bool IsPalindromic(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1]) return false;
        }
        return true;
    }
}