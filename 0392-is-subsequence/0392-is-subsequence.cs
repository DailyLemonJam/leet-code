public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;

        int sPtr = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[sPtr])
            {
                sPtr++;
                if (sPtr == s.Length) return true;
            }
        }

        GC.Collect(); // just checking
        return false;
    }
}