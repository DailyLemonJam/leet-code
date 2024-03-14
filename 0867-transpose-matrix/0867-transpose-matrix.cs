public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] res = new int[n][];

        for (int index = 0; index < n; index++) res[index] = new int[m];
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) res[j][i] = matrix[i][j];
        }

        return res;
    }
}