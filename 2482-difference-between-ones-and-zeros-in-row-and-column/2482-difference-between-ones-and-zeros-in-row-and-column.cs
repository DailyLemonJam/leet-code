public class Solution
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[] onesInRow = new int[n];
        int[] onesInColumn = new int[m];

        for (int row = 0; row < n; row++)
        {
            int onesAmountInRow = 0;
            for (int column = 0; column < m; column++)
            {
                if (grid[column][row] == 1) onesAmountInRow++;
            }
            onesInRow[row] = onesAmountInRow;
        }

        for (int column = 0; column < m; column++)
        {
            int onesAmountInColumn = 0;
            for (int row = 0; row < n; row++)
            {
                if (grid[column][row] == 1) onesAmountInColumn++;
            }
            onesInColumn[column] = onesAmountInColumn;
        }

        for (int row = 0; row < m; row++)
        {
            grid[row] = new int[n];
            for (int column = 0; column < n; column++)
            {
                grid[row][column] = onesInRow[column] + onesInColumn[row]
                    - (m - onesInRow[column]) - (n - onesInColumn[row]);
            }
        }

        return grid;
    }
}