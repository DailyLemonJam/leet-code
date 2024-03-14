public class Solution
{
    public int MinOperations(string s)
    {
        int result = int.MaxValue;
        int toChange = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0 && s[i] == '1') toChange++;
            if (i % 2 == 1 && s[i] == '0') toChange++;
        }

        if (toChange < result) result = toChange;
        toChange = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0 && s[i] == '0') toChange++;
            if (i % 2 == 1 && s[i] == '1') toChange++;
        }

        return toChange > result ? result : toChange;
    }
}