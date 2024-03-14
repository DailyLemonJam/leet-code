public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        int[] xs = new int[points.Length];

        for (int i = 0; i < points.Length; i++)
        {
            xs[i] = points[i][0];
        }

        Array.Sort(xs);

        int max = 0;

        for (int i = 0; i < xs.Length - 1; i++)
        {
            int cur = Math.Abs(xs[i] - xs[i + 1]);
            if (cur > max) max = cur;
        }

        return max;
    }
}