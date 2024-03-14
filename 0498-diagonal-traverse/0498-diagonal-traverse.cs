public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var result = new List<int>();
        var temp = new List<int>();

        int counter = 1;

        for (int i = 0; i < mat.Length; i++)
        {
            for (int x = i, y = 0; x >= 0 && y < mat[0].Length; x--, y++)
            {
                temp.Add(mat[x][y]);
            }
            if (counter % 2 == 0) temp.Reverse();
            result.AddRange(temp);
            temp.Clear();
            counter++;
        }

        for (int i = 1; i < mat[0].Length; i++)
        {
            for (int x = mat.Length - 1, y = i; x >= 0 && y < mat[0].Length; x--, y++)
            {
                temp.Add(mat[x][y]);
            }
            if (counter % 2 == 0) temp.Reverse();
            result.AddRange(temp);
            temp.Clear();
            counter++;
        }

        return result.ToArray();
    }
}