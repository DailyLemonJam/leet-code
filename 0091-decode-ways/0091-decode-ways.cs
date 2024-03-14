public class Solution
{
    public int NumDecodings(string s)
    {
        int n = s.Length;
        var res = new int[n + 1];
        res[n] = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == '0') res[i] = 0;
            else res[i] = res[i + 1];

            if (i + 1 < n && (s[i] == '1' 
                || (s[i] == '2' && (int)char.GetNumericValue(s[i + 1]) >= 0 
                && (int)char.GetNumericValue(s[i + 1]) <= 6)))
            {
                res[i] += res[i + 2];
            }
        }

        return res[0];
    }
}