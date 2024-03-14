public class Solution
{
    public int MaxPoints(int[][] points)
    {
        if (points.Length == 1) return 1;
        if (points.Length == 2) return 2;

        int max = 0;
        int counter = 2;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 2; j < points.Length; j++)
            {
                for (int k = i + 1; k < j; k++)
                    {
                        if ((points[i][0] - points[k][0]) * (points[k][1] - points[j][1]) 
                            == 
                            (points[i][1] - points[k][1]) * (points[k][0] - points[j][0]))
                            {
                                counter++;
                            }
                    }
                if (counter > max) max = counter;
                counter = 2;
            }
        }
        return max;
    }
}