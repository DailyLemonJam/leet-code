public class Solution
{
    public int Reverse(int x)
    {
        string s = x.ToString();

        var sb = new StringBuilder();

        int startIndex;
        if (x >= 0) startIndex = 0;
        else
        {
            startIndex = 1;
            sb.Append(s[0]);
        }

        for (int i = s.Length - 1; i >= startIndex; i--)
        {
            sb.Append(s[i]);
        }

        int res = 0;
        try
        {
            res = int.Parse(sb.ToString());
        }
        catch (OverflowException)
        {
            return 0;
        }
        return res;
    }
}