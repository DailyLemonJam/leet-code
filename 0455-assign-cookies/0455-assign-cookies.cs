public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int result = 0;
        int curChild = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= g[curChild])
            {
                result++;
                curChild++;
            }

            if (curChild == g.Length) return result;
        }

        return result;
    }
}