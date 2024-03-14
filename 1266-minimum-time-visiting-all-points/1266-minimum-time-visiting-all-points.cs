public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int seconds = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            int difX = Math.Abs(points[i][0] - points[i + 1][0]);
            int difY = Math.Abs(points[i][1] - points[i + 1][1]);
            seconds += difX > difY ? difX : difY;
        }
        return seconds;
    }
}